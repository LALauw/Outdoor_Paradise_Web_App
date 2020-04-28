using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Data;
using Outdoor_paradise_webapp.Models;
using X.PagedList;

namespace Outdoor_paradise_webapp.Controllers {
	[Authorize(Roles = "Admin, Marketing")]
	public class PromotionController : Controller {
		private readonly DatabaseContext _context;

		public PromotionController(DatabaseContext context) {
			_context = context;
		}

		public async Task<IQueryable<Promotion>> GetPromotionQueryable() {
			var list = await (from p in _context.Promotion
												select new Promotion {
													Id = p.Id,
													Date_start = p.Date_start,
													Date_end = p.Date_end,
													Description = p.Description,
													Name = p.Name
												}).ToListAsync();
			return list.AsQueryable();
		}

		// GET: Promotion
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.IdSortParm = string.IsNullOrEmpty(sortOrder) ? "id" : "";
			ViewBag.DstartSortParm = string.IsNullOrEmpty(sortOrder) ? "date_start" : "";
			ViewBag.DendSortParm = string.IsNullOrEmpty(sortOrder) ? "date_end" : "";
			ViewBag.DescriptionSortParm = string.IsNullOrEmpty(sortOrder) ? "description" : "";
			ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name" : "";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var list = await GetPromotionQueryable();

			if(!string.IsNullOrEmpty(searchString))
				list = list.Where(s => s.Name.Contains(searchString));

			switch(sortOrder) {
				case "id":
					list = list.OrderByDescending(p => p.Id);
					break;
				case "date_start":
					list = list.OrderByDescending(p => p.Date_start);
					break;
				case "date_end":
					list = list.OrderByDescending(p => p.Date_end);
					break;
				case "description":
					list = list.OrderByDescending(p => p.Description);
					break;
				case "name":
					list = list.OrderByDescending(p => p.Name);
					break;
				default:
					list = list.OrderBy(s => s.Id);
					break;
			}

			var pageNumber = page ?? 1;
			var productlist = new PromotionListModel {
				Promotions = list.ToPagedList(pageNumber, 15)
			};

			return View(productlist);
		}

		public async Task<Promotion> GetPromotionDetails(int? id) {
			var promotion = await (from p in _context.Promotion
														 where p.Id == id
														 select new Promotion {
															 Id = p.Id,
															 Date_start = p.Date_start,
															 Date_end = p.Date_end,
															 Description = p.Description,
															 Name = p.Name
														 }).FirstOrDefaultAsync();
			return promotion;
		}

		// GET: Promotion/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null)
				return NotFound();

			var promotion = await GetPromotionDetails(id);

			if(promotion == null)
				return NotFound();

			return View(promotion);
		}

		// GET: Promotion/Create
		public IActionResult Create() {
			return View(new Promotion());
		}

		// POST: Promotion/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Date_start,Date_end,Description,Name")] Promotion promotion) {
			var promo = new Promotion {
				Id = promotion.Id,
				Date_start = promotion.Date_start,
				Date_end = promotion.Date_end,
				Description = promotion.Description,
				Name = promotion.Name
			};

			if(ModelState.IsValid) {
				_context.Add(promo);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(promotion);
		}

		// GET: Promotion/Edit/5
		public async Task<IActionResult> Edit(short? id) {
			if(id == null)
				return NotFound();

			var promotion = from p in _context.Promotion
											where p.Id == id
											select new Promotion {
												Id = p.Id,
												Date_start = p.Date_start,
												Date_end = p.Date_end,
												Description = p.Description,
												Name = p.Name
											};

			if(promotion == null)
				return NotFound();

			var model = await promotion.FirstAsync();

			return View(model);
		}

		// POST: Promotion/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(short id, [Bind("Id,Date_start,Date_end,Description,Name")] Promotion promotion) {
			if(id != promotion.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					_context.Update(promotion);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!PromotionExists(promotion.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(promotion);
		}

		// GET: Promotion/Delete/5
		public async Task<IActionResult> Delete(int? id) {
			if(id == null)
				return NotFound();

			var promotion = await GetPromotionDetails(id);

			if(promotion == null)
				return NotFound();

			return View(promotion);
		}

		// POST: Promotion/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(short id) {
			var promotion = await _context.Promotion.FindAsync(id);
			_context.Promotion.Remove(promotion);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool PromotionExists(short id) {
			return _context.Promotion.Any(p => p.Id == id);
		}
	}
}
