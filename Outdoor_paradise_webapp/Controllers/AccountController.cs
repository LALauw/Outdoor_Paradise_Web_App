using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;

namespace Outdoor_paradise_webapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly DatabaseContext _context;


        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, DatabaseContext context) {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterBoeker(string id)
        {
            var customerAssociated = (from c in _context.Customer
                                      where c.Username == id
                                      select c).FirstOrDefault();
            if (_context.Boeker.Where(x => x.Customer == customerAssociated.Id).Any())
            {
                return View("../Shared/Error");
            }

            return View("../Account/RegisterBoeker");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RegisterBoeker(RegisterBoekerViewModel model)
        {
            if (signInManager.IsSignedIn(User))
            {


                if (ModelState.IsValid)
                {

                    var customerAssociated = (from c in _context.Customer
                                              where c.Username == model.Email
                                              select c).FirstOrDefault();

                 
                        var boeker = new Boeker
                        {
                            Customer = customerAssociated.Id,
                            IBAN = model.IBAN,
                            Birth_date = model.Birth_date,
                            sex = model.Sex
                        };
                        _context.Add(boeker);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Index", "Home");
                    
                }
            }else {
                return View("Login", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid) {
                var user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email, 
                    First_name = model.First_name,
                    Last_name = model.Last_name,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    Zip = model.Zip,
                    Phone = model.Phone,
                    Company_name = model.Company_name
                };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded) {

                    await userManager.AddToRoleAsync(user, "Customer");
                    var customer = new Customer
                    {
                        First_name = model.First_name,
                        Last_name = model.Last_name,
                        Email = model.Email,
                        Address = model.Address,
                        City = model.City,
                        State = model.State,
                        Zip = model.Zip,
                        Phone = model.Phone,
                        Company_name = model.Company_name,
                        Typecode = "S",
                        Username = user.UserName
                    };

                    _context.Add(customer);
                    await _context.SaveChangesAsync();

                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Welcome", new { id = user.Id});
                }

                foreach (var error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        
    }
}