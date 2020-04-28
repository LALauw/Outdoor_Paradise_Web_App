using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;

namespace Outdoor_paradise_webapp.Controllers
{
    [Authorize]
    public class WelcomeController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly RoleManager<IdentityRole> _role;
        private readonly UserManager<AppUser> _user;

        public WelcomeController(DatabaseContext context, UserManager<AppUser> user, RoleManager<IdentityRole> role)
        {
            _context = context;
            this._user = user;
            this._role = role;

        }
        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            foreach (var user in _user.Users) {
                if (user.Id == id) {
                    foreach (var role in _role.Roles) {
                        if (await _user.IsInRoleAsync(user, role.Name)) {
                            var userRole = role.Name;
                            if (userRole == "Admin")
                            {
                                var roles = _role.Roles;
                                return View("../Administration/ListRoles", roles);
														}
														else if(userRole == "HRM") {
															ViewBag.Role = userRole;
															return View("../HRM/Index");
														}
														else if(userRole == "Marketing") {
															ViewBag.Role = userRole;
															return View("../Marketing/Index");
														}
														else {
                                return View("../Welcome/Index", user);
                            }
                     }
                  }
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Tours() {
            var ReisViewModels = from r in _context.Reis
                                 join i in _context.Image on r.Image equals i.Id
                                 select new ReisViewModel
                                 {
                                     Id = r.Id,
                                     Name = r.Name,
                                     Kind = r.Kind,
                                     Max_deelnemers = r.Max_deelnemers,
                                     Min_deelnemers = r.Min_deelnemers,
                                     Description = r.Description,
                                     Locatie = r.Locatie,
                                     Image = r.Image,
                                     ImagePath = new Image
                                     {
                                         Id = r.Image,
                                         Name = i.Name,
                                         Imagepath = i.Imagepath
                                     },
                                 };
            return View(await ReisViewModels.ToListAsync());
        }
        
        [HttpGet]
        public async Task<IActionResult> YourTours(string username) {
            var reisViewModel = await(from r in _context.Reis
                                join i in _context.Image on r.Image equals i.Id
                                join ru in _context.Reis_uitvoering on r.Id equals ru.Reis
                                join b in _context.Boeking on ru.Id equals b.Reis_uitvoering
                                join bo in _context.Boeker on b.Boeker equals bo.Customer
                                join c in _context.Customer on bo.Customer equals c.Id
                                where c.Username == username
                                select new YourToursModel
                                {
                                    Reis = new Reis
                                    {
                                        Id = r.Id,
                                        Description = r.Description,
                                        Image = i.Id,
                                        Kind = r.Kind,
                                        Locatie = r.Locatie,
                                        Max_deelnemers = r.Max_deelnemers,
                                        Min_deelnemers = r.Min_deelnemers,
                                        Name = r.Name
                                    },
                                    Boeker = new Boeker
                                    {
                                        Customer = bo.Customer,
                                        Birth_date = bo.Birth_date,
                                        IBAN = bo.IBAN,
                                        sex = bo.sex
                                    },
                                    Customer = new Customer
                                    {
                                        Id = c.Id,
                                        First_name = c.First_name,
                                        Last_name = c.Last_name,
                                        Email = c.Email,
                                        Phone = c.Phone
                                    },
                                    Boekingen = new List<Boeking>(),
                                    Reis_uitvoeringen = new List<Reis_uitvoeringModel>()
                                }).FirstOrDefaultAsync();

            var reis_uitvoeringen = from ru in _context.Reis_uitvoering
                                    join bo in _context.Boeking on ru.Id equals bo.Reis_uitvoering
                                    join r in _context.Reis on ru.Reis equals r.Id
                                    where bo.Boeker == reisViewModel.Boeker.Customer
                                    select new Reis_uitvoeringModel {
                                        Begin_datum = ru.Begin_datum,
                                        Eind_datum = ru.Eind_datum,
                                        Prijs_per_deelnemer = ru.Prijs_per_deelnemer,
                                        Id = ru.Id,
                                        ReisObj = new Reis {
                                            Id = r.Id ,
                                            Description = r.Description,
                                            Name = r.Name,
                                            Max_deelnemers = r.Max_deelnemers,
                                            Min_deelnemers = r.Min_deelnemers,
                                            Locatie =r.Locatie,
                                            Kind = r.Kind
                                        }
                                    };



            if (reisViewModel != null) {
                reisViewModel.Reis_uitvoeringen.Clear();
                foreach (var ru in reis_uitvoeringen)
                {
                    var excursies = await (from e in _context.Excursie join eru in _context.Excursie_reis_uitvoering on
                                    e.Id equals eru.Excursie
                                    where eru.Reis_uitvoering == ru.Id
                                    select e).ToListAsync();

                    var excursiePrijs = 0.0;

                    foreach (var p in excursies)
                        excursiePrijs += p.Prijs;

                    ru.TotaalPrijs = ru.Prijs_per_deelnemer + excursiePrijs;
                    reisViewModel.Reis_uitvoeringen.Add(ru);
                }
            }
            return View(reisViewModel);
        }
    }
}