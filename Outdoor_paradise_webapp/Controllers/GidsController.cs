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
    [Authorize(Roles = "Admin, HRM")]
    public class GidsController : Controller
    {
        private readonly DatabaseContext _context;

        public GidsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Gids
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gids.ToListAsync());
        }

        // GET: Gids/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gids = await _context.Gids
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gids == null)
            {
                return NotFound();
            }

            return View(gids);
        }

        // GET: Gids/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam")] Gids gids)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gids);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gids);
        }

        // GET: Gids/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gids = await _context.Gids.FindAsync(id);
            if (gids == null)
            {
                return NotFound();
            }
            return View(gids);
        }

        // POST: Gids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam")] Gids gids)
        {
            if (id != gids.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gids);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GidsExists(gids.Id))
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
            return View(gids);
        }

        // GET: Gids/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gids = await _context.Gids
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gids == null)
            {
                return NotFound();
            }

            return View(gids);
        }

        // POST: Gids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gids = await _context.Gids.FindAsync(id);
            _context.Gids.Remove(gids);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GidsExists(int id)
        {
            return _context.Gids.Any(e => e.Id == id);
        }
    }
}
