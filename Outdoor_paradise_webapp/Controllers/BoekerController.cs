using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;

namespace Outdoor_paradise_webapp.Controllers
{
    [Authorize]
    public class BoekerController : Controller
    {
        private readonly DatabaseContext _context;

        public BoekerController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Boeker
        [Authorize(Roles = "Admin, Marketing")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boeker.ToListAsync());
        }

        // GET: Boeker/Details/5
        [Authorize(Roles = "Admin, Marketing")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boeker = await _context.Boeker
                .FirstOrDefaultAsync(m => m.Customer == id);
            if (boeker == null)
            {
                return NotFound();
            }

            return View(boeker);
        }
        [Authorize(Roles = "Admin, Marketing")]
        // GET: Boeker/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boeker/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin, Marketing")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Customer,IBAN,Birth_date,sex")] Boeker boeker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boeker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boeker);
        }

        // GET: Boeker/Edit/5
        [Authorize(Roles = "Admin, Marketing")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boeker = await _context.Boeker.FindAsync(id);
            if (boeker == null)
            {
                return NotFound();
            }
            return View(boeker);
        }

        // POST: Boeker/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin, Marketing")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Customer,IBAN,Birth_date,sex")] Boeker boeker)
        {
            if (id != boeker.Customer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boeker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoekerExists(boeker.Customer))
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
            return View(boeker);
        }

        // GET: Boeker/Delete/5
        [Authorize(Roles = "Admin, Marketing")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boeker = await _context.Boeker
                .FirstOrDefaultAsync(m => m.Customer == id);
            if (boeker == null)
            {
                return NotFound();
            }

            return View(boeker);
        }

        // POST: Boeker/Delete/5
        [Authorize(Roles = "Admin, Marketing")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boeker = await _context.Boeker.FindAsync(id);
            _context.Boeker.Remove(boeker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoekerExists(int id)
        {
            return _context.Boeker.Any(e => e.Customer == id);
        }
    }
}
