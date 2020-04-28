using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;
using X.PagedList;

namespace Outdoor_paradise_webapp.Controllers {
	[Authorize]
	public class Reis_uitvoeringController : Controller {
		private readonly DatabaseContext _context;

		public Reis_uitvoeringController(DatabaseContext context) {
			_context = context;
		}

        // GET: Reis_uitvoering
        [Authorize(Roles = "Admin, Marketing")]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.BeginDatumSortParm = String.IsNullOrEmpty(sortOrder) ? "begin_datum" : "";
			ViewBag.EindDatumSortParm = String.IsNullOrEmpty(sortOrder) ? "Eind_datum" : "";
			ViewBag.PrijsSortParm = String.IsNullOrEmpty(sortOrder) ? "prijs" : "";
			ViewBag.ReisSortParm = String.IsNullOrEmpty(sortOrder) ? "reis" : "";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var reis_uitvoeringen = await (from ru in _context.Reis_uitvoering
																		 join r in _context.Reis on ru.Reis equals r.Id
																		 select new Reis_uitvoeringModel {
																			 Id = ru.Id,
																			 Begin_datum = ru.Begin_datum,
																			 Eind_datum = ru.Eind_datum,
																			 Prijs_per_deelnemer = ru.Prijs_per_deelnemer,
																			 Reis = ru.Reis,
																			 ReisObj = new Reis {
																				 Id = r.Id,
																				 Description = r.Description,
																				 Max_deelnemers = r.Max_deelnemers,
																				 Min_deelnemers = r.Min_deelnemers,
																				 Locatie = r.Locatie,
																				 Name = r.Name,
																				 Kind = r.Kind,
																				 Image = r.Image
																			 }
																		 }).ToListAsync();

			foreach(var ru in reis_uitvoeringen) {
				var count = await (from ruv in _context.Reis_uitvoering
													 join b in _context.Boeking on ruv.Id equals b.Reis_uitvoering
													 where ruv.Id == ru.Id
													 select b).CountAsync();

				var exCount = await (from rut in _context.Reis_uitvoering
														 join eru in _context.Excursie_reis_uitvoering on rut.Id equals eru.Reis_uitvoering
														 where rut.Id == ru.Id
														 select eru).CountAsync();

				var excursiePrijsList = await (from rut in _context.Reis_uitvoering
																			 join eru in _context.Excursie_reis_uitvoering on rut.Id equals eru.Reis_uitvoering
																			 join e in _context.Excursie on eru.Excursie equals e.Id
																			 where rut.Id == ru.Id
																			 select e.Prijs).ToListAsync();

				var excursiePrijs = 0.0;

				foreach(var p in excursiePrijsList) {
					excursiePrijs += p;
				}

				ru.TotaalPrijs = ru.Prijs_per_deelnemer + excursiePrijs;
				ru.countBookings = count;
				ru.CountExcursies = exCount;
			}

			var queryableList = reis_uitvoeringen.AsQueryable();

			switch(sortOrder) {
				case "begin_datum":
					queryableList = queryableList.OrderByDescending(s => s.Begin_datum);
					break;
				case "eind_datum":
					queryableList = queryableList.OrderByDescending(s => s.Eind_datum);
					break;
				case "prijs":
					queryableList = queryableList.OrderByDescending(s => s.Prijs_per_deelnemer);
					break;
				case "reis":
					queryableList = queryableList.OrderByDescending(s => s.ReisObj.Name);
					break;
				default:
					queryableList = queryableList.OrderBy(s => s.Id);
					break;
			}

			var pageNumber = page ?? 1;

			var reis_uitvoeringenList = queryableList.ToPagedList(pageNumber, 15);

			return View(reis_uitvoeringenList);
		}

        // GET: Reis_uitvoering/Details/5
        [Authorize(Roles = "Admin, Marketing")]
        public async Task<IActionResult> Details(int? id) {
			var uitvoering = await (from ru in _context.Reis_uitvoering
															where ru.Id == id
															select ru).FirstOrDefaultAsync();

			var excursies = await (from e in _context.Excursie
														 join eru in _context.Excursie_reis_uitvoering on e.Id equals eru.Excursie
														 join g in _context.Gids on e.Gids equals g.Id
														 where eru.Reis_uitvoering == id
														 select new ExcursieIndexModel {
															 Id = e.Id,
															 Datum = e.Datum,
															 Description = e.Description,
															 Gids = e.Gids,
															 GidsNaam = g.Naam,
															 Name = e.Name,
															 Prijs = e.Prijs
														 }).ToListAsync();

			var model = new Reis_uitvoeringCreateModel {
				Id = uitvoering.Id,
				Begin_datum = uitvoering.Begin_datum,
				Eind_datum = uitvoering.Eind_datum,
				Prijs_per_deelnemer = uitvoering.Prijs_per_deelnemer,
				ExcursiesModel = new List<ExcursieIndexModel>()
			};

			if(excursies.Count != 0) {
				foreach(var ex in excursies)
					model.ExcursiesModel.Add(ex);
			}


			return View(model);
		}

		public async Task<IActionResult> CustomerDetails(int? id) {
			if(id == null)
				return NotFound();

			var reis_uitvoering = await (from ru in _context.Reis_uitvoering
																	 join r in _context.Reis on ru.Reis equals r.Id
																	 where ru.Id == id
																	 select new Reis_uitvoeringModel {
																		 Id = ru.Id,
																		 Begin_datum = ru.Begin_datum,
																		 Eind_datum = ru.Eind_datum,
																		 Prijs_per_deelnemer = ru.Prijs_per_deelnemer,
																		 Reis = ru.Reis,
																		 ReisObj = new Reis {
																			 Id = r.Id,
																			 Description = r.Description,
																			 Max_deelnemers = r.Max_deelnemers,
																			 Min_deelnemers = r.Min_deelnemers,
																			 Locatie = r.Locatie,
																			 Name = r.Name,
																			 Kind = r.Kind,
																			 Image = r.Image
																		 },
                                                                         Excursies = new List<ExcursieIndexModel>()
																	 }).FirstOrDefaultAsync();

			var count = await (from ruv in _context.Reis_uitvoering
												 join b in _context.Boeking on ruv.Id equals b.Reis_uitvoering
												 where ruv.Id == id
												 select b).CountAsync();

			var excursieList = await (from e in _context.Excursie
                                      join eru in _context.Excursie_reis_uitvoering on e.Id equals eru.Excursie
                                      join g in _context.Gids on e.Gids equals g.Id
                                      where eru.Reis_uitvoering == reis_uitvoering.Id
                                      select new ExcursieIndexModel
                                      {
                                          Id = e.Id,
                                          Datum = e.Datum,
                                          Description = e.Description,
                                          Gids = e.Gids,
                                          GidsNaam = g.Naam,
                                          Name = e.Name,
                                          Prijs = e.Prijs
                                      }).ToListAsync();

            /*
            var medereizigers = (from m in _context.Medereiziger
                                 where m.Reis_uitvoering == reis_uitvoering.Id
                                      select new Medereiziger{
                                          Id = m.Id,
                                          BirthDate = m.BirthDate,
                                          Naam = m.Naam,
                                          Reis_uitvoering = m.Reis_uitvoering,
                                          Sex = m.Sex
                                      }).ToList();
 
            foreach (var m in medereizigers)
            {
                reis_uitvoering.Medereizigers.Add(m);
            }
            */
            if (reis_uitvoering.Excursies.Any()) {
                reis_uitvoering.Excursies.Clear();
            }
			var excursiePrijs = 0.0;

            foreach (var p in excursieList)
            {
                excursiePrijs += p.Prijs;
                reis_uitvoering.Excursies.Add(p);
            }

			reis_uitvoering.TotaalPrijs = reis_uitvoering.Prijs_per_deelnemer + excursiePrijs;
			reis_uitvoering.countBookings = count;


			if(reis_uitvoering == null)
				return NotFound();

			return View(reis_uitvoering);
		}

		// GET: Reis_uitvoering/Create
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Create() {
			var reizen = await (from r in _context.Reis
													select r).ToListAsync();
			/*
var excursies = await (from e in _context.Excursie
														 join eru in _context.Excursie_reis_uitvoering on e.Id equals eru.Excursie
														 join ru in _context.Reis_uitvoering on eru.Reis_uitvoering equals ru.Id
														 where e.Datum > ru.Begin_datum && e.Datum < ru.Eind_datum
											 select e).ToListAsync();*/
			var excursies = await (from e in _context.Excursie select e).ToListAsync();

			var model = new Reis_uitvoeringCreateModel {
				Excursies = excursies,
				Reizen = reizen
			};
			return View(model);
		}

		public IActionResult CreateError() {
			return View();
		}

		// POST: Reis_uitvoering/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Begin_datum,Eind_datum,Prijs_per_deelnemer,Reis")] Reis_uitvoeringModel reis_uitvoering, int[] checks) {

			if(ModelState.IsValid) {
				List<Excursie> exList = new List<Excursie>();
				foreach(var c in checks) {
					var excursie = await (from e in _context.Excursie
																where e.Id == c
																select e).FirstOrDefaultAsync();
					exList.Add(excursie);
				}
				_context.Add(reis_uitvoering);
				_context.SaveChanges();
				var ruId = _context.Reis_uitvoering.Last().Id;

				foreach(var ex in exList) {
					if(ex.Datum > reis_uitvoering.Begin_datum && ex.Datum < reis_uitvoering.Eind_datum) {
						var excursie_reis = new Excursie_reis_uitvoering {
							Excursie = ex.Id,
							Reis_uitvoering = ruId
						};
						_context.Excursie_reis_uitvoering.Add(excursie_reis);
						await _context.SaveChangesAsync();
					}
					else {
						var removeExcursion = await (_context.Excursie_reis_uitvoering.Where(r => r.Reis_uitvoering == ruId)).ToListAsync();
						if(removeExcursion != null) {
							foreach(var item in removeExcursion) {
								_context.Excursie_reis_uitvoering.Remove(item);
							}
						}

						var removeReisU = await (_context.Reis_uitvoering.Where(ru => ru.Id == ruId)).FirstOrDefaultAsync();
						_context.Reis_uitvoering.Remove(removeReisU);
						await _context.SaveChangesAsync();
						return RedirectToAction(nameof(CreateError));
					}

				}
				return RedirectToAction(nameof(Index));
			}
			return View(reis_uitvoering);
		}

		// GET: Reis_uitvoering/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null) {
				return NotFound();
			}
			var reis_uitvoering = await _context.Reis_uitvoering.FindAsync(id);
			var reizen = await (from r in _context.Reis
													select r).ToListAsync();

			if(_context.Excursie_reis_uitvoering.Where(ex => ex.Reis_uitvoering == reis_uitvoering.Id).Count() == 0) {

				var excursiesCheckbox = await (from e in _context.Excursie
																			 let selected = (from eru in _context.Excursie_reis_uitvoering
																											 where eru.Reis_uitvoering == id && e.Id == eru.Excursie
																											 select eru).Count() == 1
																			 select new ExcursieChecked {
																				 Id = e.Id,
																				 Datum = e.Datum,
																				 Description = e.Description,
																				 Gids = e.Gids,
																				 Name = e.Name,
																				 Prijs = e.Prijs,
																				 Selected = false
																			 }).ToListAsync();


				var model = new Reis_uitvoeringEditModel {
					Id = reis_uitvoering.Id,
					Begin_datum = reis_uitvoering.Begin_datum,
					Eind_datum = reis_uitvoering.Eind_datum,
					Prijs_per_deelnemer = reis_uitvoering.Prijs_per_deelnemer,
					Reizen = reizen,
					Excursiesheckbox = excursiesCheckbox,
				};

				return View("Edit", model);
			}
			else {
				//o.b.v. SQL query:     SELECT *, (SELECT COUNT(*) FROM excursie_reis_uitvoering eru WHERE e.id = eru.excursie AND eru.reis_uitvoering = 11) AS xd FROM excursie e
				var excursiesCheckbox = await (from e in _context.Excursie
																			 let selected = (from eru in _context.Excursie_reis_uitvoering
																											 where eru.Reis_uitvoering == id && e.Id == eru.Excursie
																											 select eru).Count() == 1
																			 select new ExcursieChecked {
																				 Id = e.Id,
																				 Datum = e.Datum,
																				 Description = e.Description,
																				 Gids = e.Gids,
																				 Name = e.Name,
																				 Prijs = e.Prijs,
																				 Selected = selected
																			 }).ToListAsync();


				var model = new Reis_uitvoeringEditModel {
					Id = reis_uitvoering.Id,
					Begin_datum = reis_uitvoering.Begin_datum,
					Eind_datum = reis_uitvoering.Eind_datum,
					Prijs_per_deelnemer = reis_uitvoering.Prijs_per_deelnemer,
					Reizen = reizen,
					Excursiesheckbox = excursiesCheckbox,
				};

				var removeEx = new List<ExcursieChecked>();
				foreach(var excursie in excursiesCheckbox) {
					if(excursie.Selected == false) {
						if(excursie.Datum < reis_uitvoering.Begin_datum || excursie.Datum > reis_uitvoering.Eind_datum) {
							removeEx.Add(excursie);
						}
					}

				}

				foreach(var item in removeEx) {
					model.Excursiesheckbox.Remove(item);
				}
				if(reis_uitvoering == null) {
					return NotFound();
				}
				return View(model);
			}
		}

		// POST: Reis_uitvoering/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Begin_datum,Eind_datum,Prijs_per_deelnemer,Reis")] Reis_uitvoering reis_uitvoering, int[] checks) {
			if(id != reis_uitvoering.Id) {
				return NotFound();
			}
			if(ModelState.IsValid) {
				try {
					_context.Update(reis_uitvoering);
					_context.SaveChanges();

					var eru = await (from eruc in _context.Excursie_reis_uitvoering
													 where eruc.Reis_uitvoering == id
													 select eruc).ToListAsync();

					foreach(var euitvoering in eru) {
						_context.Excursie_reis_uitvoering.Remove(euitvoering);
						_context.SaveChanges();
					}

					foreach(var item in checks) {
						var excursie_reis = new Excursie_reis_uitvoering {
							Excursie = item,
							Reis_uitvoering = id
						};
						_context.Excursie_reis_uitvoering.Add(excursie_reis);
						await _context.SaveChangesAsync();

					};

				}
				catch(DbUpdateConcurrencyException) {
					if(!Reis_uitvoeringExists(reis_uitvoering.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(reis_uitvoering);
		}

		// GET: Reis_uitvoering/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}


			var reis_uitvoering = await (from ru in _context.Reis_uitvoering
																	 join r in _context.Reis on ru.Reis equals r.Id
																	 where ru.Id == id
																	 select new Reis_uitvoeringModel {
																		 Id = ru.Id,
																		 Begin_datum = ru.Begin_datum,
																		 Eind_datum = ru.Eind_datum,
																		 Prijs_per_deelnemer = ru.Prijs_per_deelnemer,
																		 Reis = ru.Reis,
																		 ReisObj = new Reis {
																			 Id = r.Id,
																			 Description = r.Description,
																			 Max_deelnemers = r.Max_deelnemers,
																			 Min_deelnemers = r.Min_deelnemers,
																			 Locatie = r.Locatie,
																			 Name = r.Name,
																			 Kind = r.Kind,
																			 Image = r.Image
																		 }
																	 }).FirstOrDefaultAsync();
			if(reis_uitvoering == null) {
				return NotFound();
			}

			return View(reis_uitvoering);
		}

		// POST: Reis_uitvoering/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			try {
				var excursies = await (_context.Excursie_reis_uitvoering.Where(e => e.Reis_uitvoering == id).ToListAsync());
				foreach(var e in excursies) {
					_context.Excursie_reis_uitvoering.Remove(e);
				}
				var reis_uitvoering = await _context.Reis_uitvoering.FindAsync(id);
				_context.Reis_uitvoering.Remove(reis_uitvoering);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			catch {
				return View("../Shared/BookingDeleteError");
			}
		}

		private bool Reis_uitvoeringExists(int id) {
			return _context.Reis_uitvoering.Any(e => e.Id == id);
		}
	}
}
