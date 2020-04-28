using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;

namespace Outdoor_paradise_webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context) {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
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

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
