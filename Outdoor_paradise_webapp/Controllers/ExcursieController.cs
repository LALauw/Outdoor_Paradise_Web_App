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

namespace Outdoor_paradise_webapp.Controllers {
	[Authorize(Roles = "Admin, Marketing")]
	public class ExcursieController : Controller {
		private readonly DatabaseContext _context;

		public ExcursieController(DatabaseContext context) {
			_context = context;
		}

		// GET: Excursie
		public async Task<IActionResult> Index() {
			var excursies = await (from e in _context.Excursie
														 join g in _context.Gids on e.Gids equals g.Id
														 select new ExcursieIndexModel {
															 Id = e.Id,
															 Datum = e.Datum,
															 Description = e.Description,
															 Gids = e.Gids,
															 Prijs = e.Prijs,
															 Name = e.Name,
															 GidsNaam = g.Naam
														 }).ToListAsync();
			return View(excursies);
		}

		// GET: Excursie/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null) {
				return NotFound();
			}
			var excursies = await (from e in _context.Excursie
														 join g in _context.Gids on e.Gids equals g.Id
														 where e.Id == id
														 select new ExcursieIndexModel {
															 Id = e.Id,
															 Datum = e.Datum,
															 Description = e.Description,
															 Gids = e.Gids,
															 Prijs = e.Prijs,
															 Name = e.Name,
															 GidsNaam = g.Naam
														 }).FirstOrDefaultAsync();
			if(excursies == null) {
				return NotFound();
			}

			return View(excursies);
		}

		// GET: Excursie/Create
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Create() {
			var gidsen = await (from g in _context.Gids
													select g).ToListAsync();
			var ExcursieModel = new ExcursieCreateModel {
				Gidsen = gidsen
			};
			return View(ExcursieModel);
		}

		// POST: Excursie/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Datum,Prijs,Description,Gids,Name")] Excursie excursie) {
			if(ModelState.IsValid) {
				_context.Add(excursie);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(excursie);
		}

		// GET: Excursie/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null) {
				return NotFound();
			}
			var gidsen = await (from g in _context.Gids
													select g).ToListAsync();
			var ex = await (from e in _context.Excursie
											where e.Id == id
											select e).FirstOrDefaultAsync();
			var ExcursieModel = new ExcursieCreateModel {
				Id = ex.Id,
				Datum = ex.Datum,
				Description = ex.Description,
				Prijs = ex.Prijs,
				Gids = ex.Gids,
				Name = ex.Name,
				Gidsen = gidsen
			};

			if(ExcursieModel == null) {
				return NotFound();
			}
			return View(ExcursieModel);
		}

		// POST: Excursie/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Datum,Prijs,Description,Gids,Name")] Excursie excursie) {
			if(id != excursie.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					_context.Update(excursie);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!ExcursieExists(excursie.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(excursie);
		}

		// GET: Excursie/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}
			var excursies = await (from e in _context.Excursie
														 join g in _context.Gids on e.Gids equals g.Id
														 where e.Id == id
														 select new ExcursieIndexModel {
															 Id = e.Id,
															 Datum = e.Datum,
															 Description = e.Description,
															 Gids = e.Gids,
															 Prijs = e.Prijs,
															 Name = e.Name,
															 GidsNaam = g.Naam
														 }).FirstOrDefaultAsync();
			if(excursies == null) {
				return NotFound();
			}

			return View(excursies);
		}

		// POST: Excursie/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var excursie = await _context.Excursie.FindAsync(id);
			_context.Excursie.Remove(excursie);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ExcursieExists(int id) {
			return _context.Excursie.Any(e => e.Id == id);
		}
	}
}
