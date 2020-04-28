using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Outdoor_paradise_webapp.Controllers
{
    [Authorize(Roles = "HRM")]
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}