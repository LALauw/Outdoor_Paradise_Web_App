using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Outdoor_paradise_webapp.Controllers
{
    [Authorize]
    public class BoekingController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public BoekingController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, DatabaseContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }

        // GET: Boeking
        [Authorize(Roles = "Admin, Marketing, HRM")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boeking.ToListAsync());
        }

        // GET: Boeking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boeking = await _context.Boeking
                .FirstOrDefaultAsync(m => m.Boeker == id);
            if (boeking == null)
            {
                return NotFound();
            }

            return View(boeking);
        }


        public IActionResult MedereizigersJa(int? reis_uitvoering, int? reis) {
            MeegeefModel model = new MeegeefModel
            {
                Reis = reis,
                Reis_uitvoering = reis_uitvoering
            };


            return View(model);
        }
        [HttpGet]
        public IActionResult AantalInvul(MeegeefModel model) {
            MeegeefModel2 model2 = new MeegeefModel2
            {
                Reis = model.Reis,
                Reis_uitvoering = model.Reis_uitvoering
            };
            return View(model2);
        }

       [HttpPost]
        public IActionResult AantalInvul([Bind("Reis,Reis_uitvoering,Aantal")] MeegeefModel2 model)
        {
            return RedirectToAction("Create", "Boeking", model);
        }
     

        [Authorize(Roles="Admin, HRM, Customer")]
        public async Task<IActionResult> Create(MeegeefModel2 modelxd)
        {
            var user = userManager.GetUserName(User);
            if (_context.Customer.Where(c => c.Username == user) != null) {
                var customer = await (from c in _context.Customer
                               where c.Username == user
                               select c).FirstOrDefaultAsync();
                var exists = (from b in _context.Boeker
                             where b.Customer == customer.Id
                             select b).Count();

                if (exists != 0)
                {
                    var reis_uitvoering_obj = await (from ru in _context.Reis_uitvoering
                                                     where ru.Id == modelxd.Reis_uitvoering
                                                     select ru).FirstOrDefaultAsync();
                    var reis_obj = await (from r in _context.Reis
                                          where r.Id == modelxd.Reis
                                          select r).FirstOrDefaultAsync();
                    var boeker = await (from b in _context.Boeker
                                        where customer.Id == b.Customer
                                        select b).FirstOrDefaultAsync();
                    BoekingCreateModel model = new BoekingCreateModel
                    {
                        Customer = customer,
                        Boekende = boeker,
                        Reis = reis_obj,
                        Reis_Uitvoering = reis_uitvoering_obj,
                        Datum = DateTime.Now,
                        TotaalPrijs = 0.0,
                        Aantal = modelxd.Aantal
                    };

                    var excursies = await (from e in _context.Excursie
                                           join eru in _context.Excursie_reis_uitvoering on e.Id equals eru.Excursie
                                           join g in _context.Gids on e.Gids equals g.Id
                                           where eru.Reis_uitvoering == reis_uitvoering_obj.Id
                                           select e
                                   ).ToListAsync();

                    var excursiePrijs = 0.0;

                    foreach (var p in excursies)
                        excursiePrijs += p.Prijs;

                    model.TotaalPrijs = model.Reis_Uitvoering.Prijs_per_deelnemer + excursiePrijs;

                    return View(model);
                }
                else {
                    return View("NoBooker");
                }
            }
            return View();
        }

        // POST: Boeking/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Boeker,Reis_uitvoering,Datum")] Boeking boeking, List<Medereiziger>medereizigers)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var m in medereizigers) {
                        m.Reis_uitvoering = boeking.Reis_uitvoering;
                        _context.Medereiziger.Add(m);
                        await _context.SaveChangesAsync();
                    }
                    _context.Add(boeking);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Success", "Boeking");
                }
                catch {
                    return View("../Shared/AlreadyBooked");
                }

            }
            return View(boeking);
        }

        public IActionResult Success() {
            return View();
        }

        // GET: Boeking/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boeking = await _context.Boeking.FindAsync(id);
            if (boeking == null)
            {
                return NotFound();
            }
            return View(boeking);
        }

        // POST: Boeking/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Boeker,Reis_uitvoering,Datum")] Boeking boeking)
        {
            if (id != boeking.Boeker)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boeking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoekingExists(boeking.Boeker))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(boeking);
        }

        // GET: Boeking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var username = userManager.GetUserName(User);
            var customerId = await (from c in _context.Customer
                             where c.Username == username
                             select c.Id).FirstOrDefaultAsync();
            var reisUitvoering = await (from ru in _context.Reis_uitvoering
                                 join r in _context.Reis on ru.Reis equals r.Id
                                 join b in _context.Boeking on ru.Id equals b.Reis_uitvoering
                                 join boe in _context.Boeker on b.Boeker equals boe.Customer
                                 where boe.Customer == customerId && ru.Id == id
                                 select new Reis_uitvoeringModel
                                 {
                                     Id = ru.Id,
                                     Begin_datum = ru.Begin_datum,
                                     Eind_datum = ru.Eind_datum,
                                     Prijs_per_deelnemer = ru.Prijs_per_deelnemer,
                                     boeker = customerId,
                                     ReisObj = new Reis
                                     {
                                         Id = r.Id,
                                         Description = r.Description,
                                         Name = r.Name,
                                         Locatie = r.Locatie
                                     }
                                 }).FirstOrDefaultAsync();
            var excursies = await (from e in _context.Excursie
                                   join eru in _context.Excursie_reis_uitvoering on e.Id equals eru.Excursie
                                   join g in _context.Gids on e.Gids equals g.Id
                                   where eru.Reis_uitvoering == id
                                   select e
                                   ).ToListAsync();

            var excursiePrijs = 0.0;

            foreach (var p in excursies)
                excursiePrijs += p.Prijs;

            reisUitvoering.TotaalPrijs = reisUitvoering.Prijs_per_deelnemer + excursiePrijs;
            return View(reisUitvoering);
        }
        public IActionResult SuccessCancel() {
            return View();
        }
        // POST: Boeking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, int boeker)
        {
            try
            {
                var boeking = await (from b in _context.Boeking
                                     where b.Boeker == boeker && b.Reis_uitvoering == id
                                     select b).FirstOrDefaultAsync();

                _context.Boeking.Remove(boeking); ;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SuccessCancel));
            }
            catch {
                return View("../Shared/NoSuchBooking");
            }

        }


        public async Task<IActionResult> CustomerDetails(int? reis_uitvoering)
        {
            var uitvoering = await (from ru in _context.Reis_uitvoering
                                    where ru.Id == reis_uitvoering
                                    select ru).FirstOrDefaultAsync();
            var excursies = await (from e in _context.Excursie
                                   join eru in _context.Excursie_reis_uitvoering on e.Id equals eru.Excursie
                                   join g in _context.Gids on e.Gids equals g.Id
                                   where eru.Reis_uitvoering == reis_uitvoering
                                   select new ExcursieIndexModel {
                                       Id = e.Id,
                                       Datum = e.Datum,
                                       Description = e.Description,
                                       Gids = e.Gids,
                                       GidsNaam = g.Naam,
                                       Name = e.Name,
                                       Prijs = e.Prijs
                                   }).ToListAsync();

            var excursiePrijs = 0.0;

            foreach (var p in excursies)
                excursiePrijs += p.Prijs;




            var model = new Reis_uitvoeringCreateModel
            {
                Id = uitvoering.Id,
                Begin_datum = uitvoering.Begin_datum,
                Eind_datum = uitvoering.Eind_datum,
                Prijs_per_deelnemer = uitvoering.Prijs_per_deelnemer,
                TotaalPrijs = 0.0,
                ExcursiesModel = new List<ExcursieIndexModel>()
            };

            model.TotaalPrijs = uitvoering.Prijs_per_deelnemer + excursiePrijs;

            if (excursies.Count != 0) {
                foreach (var ex in excursies)
                {
                    model.ExcursiesModel.Add(ex);
                }
            }


            return View(model);
        }


        private bool BoekingExists(int id)
        {
            return _context.Boeking.Any(e => e.Boeker == id);
        }
    }
}
