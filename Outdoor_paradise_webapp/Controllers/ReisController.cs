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
	[Authorize]
	public class ReisController : Controller {
		private readonly DatabaseContext _context;

		public ReisController(DatabaseContext context) {
			_context = context;
		}

        // GET: Reis
        [Authorize(Roles="Admin, Marketing")]
        public async Task<IActionResult> Index() {
			var ReisViewModels = from r in _context.Reis
													 join i in _context.Image on r.Image equals i.Id
													 select new ReisViewModel {
														 Id = r.Id,
														 Name = r.Name,
														 Kind = r.Kind,
														 Max_deelnemers = r.Max_deelnemers,
														 Min_deelnemers = r.Min_deelnemers,
														 Description = r.Description,
														 Locatie = r.Locatie,
														 Image = r.Image,
														 ImagePath = new Image {
															 Id = r.Image,
															 Name = i.Name,
															 Imagepath = i.Imagepath
														 },
													 };

			return View(await ReisViewModels.ToListAsync());
		}

        // GET: Reis/Details/5
        public async Task<IActionResult> Details(int? id) {
			if(id == null)
				return NotFound();

			var ReisViewModels = (from r in _context.Reis
														join i in _context.Image on r.Image equals i.Id
														join ru in _context.Reis_uitvoering on r.Id equals ru.Reis
														where r.Id == id
														select new ReisViewModel {
															Id = r.Id,
															Name = r.Name,
															Kind = r.Kind,
															Max_deelnemers = r.Max_deelnemers,
															Min_deelnemers = r.Min_deelnemers,
															Description = r.Description,
															Locatie = r.Locatie,
															Image = r.Image,
															ImagePath = new Image {
																Id = r.Image,
																Name = i.Name,
																Imagepath = i.Imagepath
															},
															Uitvoeringen = new List<Reis_uitvoeringModel>(),

														}).FirstOrDefault();

			if(ReisViewModels == null) {
				var ReisViewModelsNone = await (from r in _context.Reis
																				join i in _context.Image on r.Image equals i.Id
																				where r.Id == id
																				select new ReisViewModel {
																					Id = r.Id,
																					Name = r.Name,
																					Kind = r.Kind,
																					Max_deelnemers = r.Max_deelnemers,
																					Min_deelnemers = r.Min_deelnemers,
																					Description = r.Description,
																					Locatie = r.Locatie,
																					Image = r.Image,
																					ImagePath = new Image {
																						Id = r.Image,
																						Name = i.Name,
																						Imagepath = i.Imagepath
																					}
																				}).FirstOrDefaultAsync();

				return View(ReisViewModelsNone);
			}

			var uitvoeringen = (from r in _context.Reis
													join ru in _context.Reis_uitvoering on r.Id equals ru.Reis
													where r.Id == id
													select new Reis_uitvoeringModel {
														Id = ru.Id,
														Begin_datum = ru.Begin_datum,
														Eind_datum = ru.Eind_datum,
														Prijs_per_deelnemer = ru.Prijs_per_deelnemer,

													}).ToList();

			ReisViewModels.Uitvoeringen.Clear();

			foreach(var uitvoering in uitvoeringen) {
				var count = await (from ru in _context.Reis_uitvoering
													 join b in _context.Boeking on ru.Id equals b.Reis_uitvoering
													 where ru.Id == uitvoering.Id
													 select b).CountAsync();

				var exCount = await (from ru in _context.Reis_uitvoering
														 join eru in _context.Excursie_reis_uitvoering on ru.Id equals eru.Reis_uitvoering
														 where ru.Id == uitvoering.Id
														 select eru).CountAsync();

				var excursiePrijsList = await (from ru in _context.Reis_uitvoering
																			 join eru in _context.Excursie_reis_uitvoering on ru.Id equals eru.Reis_uitvoering
																			 join e in _context.Excursie on eru.Excursie equals e.Id
																			 where ru.Id == uitvoering.Id
																			 select e.Prijs).ToListAsync();

				var excursiePrijs = 0.0;

				foreach(var p in excursiePrijsList)
					excursiePrijs += p;

				uitvoering.TotaalPrijs = uitvoering.Prijs_per_deelnemer + excursiePrijs;

				ReisViewModels.Uitvoeringen.Add(new Reis_uitvoeringModel {

					Id = uitvoering.Id,
					Begin_datum = uitvoering.Begin_datum,
					Eind_datum = uitvoering.Eind_datum,
					Prijs_per_deelnemer = uitvoering.Prijs_per_deelnemer,
					TotaalPrijs = uitvoering.TotaalPrijs,
					Reis = ReisViewModels.Id,
					countBookings = count,
					CountExcursies = exCount
				});
			}

			return View(ReisViewModels);
		}

		// GET: Reis/AdminDetails/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> AdminDetails(int? id) {
			if(id == null)
				return NotFound();

			var ReisViewModels = await (from r in _context.Reis
																	join i in _context.Image on r.Image equals i.Id
																	where r.Id == id
																	select new ReisViewModel {
																		Id = r.Id,
																		Name = r.Name,
																		Kind = r.Kind,
																		Max_deelnemers = r.Max_deelnemers,
																		Min_deelnemers = r.Min_deelnemers,
																		Description = r.Description,
																		Locatie = r.Locatie,
																		Image = r.Image,
																		ImagePath = new Image {
																			Id = r.Image,
																			Name = i.Name,
																			Imagepath = i.Imagepath
																		},
																	}).FirstOrDefaultAsync();

			if(ReisViewModels == null)
				return NotFound();

			return View(ReisViewModels);
		}

		// GET: Reis/Create
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Create() {
			var images = await (from i in _context.Image
													where i.Imagepath != null
													select i).ToListAsync();

			ReisCreateModel reisCreateModel = new ReisCreateModel {
				Images = images
			};

			return View(reisCreateModel);
		}

		// POST: Reis/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Locatie,Name,Description,Kind,Max_deelnemers,Min_deelnemers,Image")] Reis reis) {
			if(ModelState.IsValid) {
				_context.Add(reis);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(reis);
		}

		// GET: Reis/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null)
				return NotFound();

			var reis = await _context.Reis.FindAsync(id);

			var images = await (from i in _context.Image
													where i.Imagepath != null
													select i).ToListAsync();

			ReisCreateModel reisCreateModel = new ReisCreateModel {
				Images = images,
				Id = reis.Id,
				Max_deelnemers = reis.Max_deelnemers,
				Min_deelnemers = reis.Min_deelnemers,
				Image = reis.Image,
				Kind = reis.Kind,
				Description = reis.Description,
				Name = reis.Name,
				Locatie = reis.Locatie
			};

			if(reis == null)
				return NotFound();

			return View(reisCreateModel);
		}

		// POST: Reis/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Locatie,Name,Description,Kind,Max_deelnemers,Min_deelnemers,Image")] Reis reis) {
			if(id != reis.Id)
				return NotFound();

			if(ModelState.IsValid) {
				try {
					//_context.Entry(reis).State = EntityState.Modified;
					_context.Update(reis);

					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!ReisExists(reis.Id))
						return NotFound();
					else
						throw;
				}
				return RedirectToAction(nameof(Index));
			}

			return View(reis);
		}

		// GET: Reis/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null)
				return NotFound();

			var ReisViewModels = await (from r in _context.Reis
																	join i in _context.Image on r.Image equals i.Id
																	where r.Id == id
																	select new ReisViewModel {
																		Id = r.Id,
																		Name = r.Name,
																		Kind = r.Kind,
																		Max_deelnemers = r.Max_deelnemers,
																		Min_deelnemers = r.Min_deelnemers,
																		Description = r.Description,
																		Locatie = r.Locatie,
																		Image = r.Image,
																		ImagePath = new Image {
																			Id = r.Image,
																			Name = i.Name,
																			Imagepath = i.Imagepath
																		},
																	}).FirstOrDefaultAsync();

			if(ReisViewModels == null)
				return NotFound();

			return View(ReisViewModels);
		}

		// POST: Reis/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var reis = await _context.Reis.FindAsync(id);
			_context.Reis.Remove(reis);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ReisExists(int id) {
			return _context.Reis.Any(e => e.Id == id);
		}
	}
}
