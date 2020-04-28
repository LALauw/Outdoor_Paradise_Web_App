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
using X.PagedList;

namespace Outdoor_paradise_webapp.Controllers {
	[Authorize(Roles = "Admin, HRM")]
	public class BonusController : Controller {
		private readonly DatabaseContext _context;
		private EmployeeController EmployeeController;

		public BonusController(DatabaseContext context) {
			_context = context;
			EmployeeController employeeController = new EmployeeController(context);
			EmployeeController = employeeController;
		}

		public async Task<IQueryable<BonusIndexModel>> GetBonusIndexModelQueryable() {
			var list = await (from b in _context.Bonus
												join e in _context.Employee on b.Employee equals e.Id
												select new BonusIndexModel {
													Id = b.Id,
													Employee = b.Employee,
													EmployeeName = e.First_name + " " + e.Last_name,
													Amount = b.Amount,
													Date = b.Date
												}).ToListAsync();
			return list.AsQueryable();
		}

		// GET: Bonus
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.EmployeeSortParm = String.IsNullOrEmpty(sortOrder) ? "employee" : "";
			ViewBag.DateSortParm = String.IsNullOrEmpty(sortOrder) ? "date" : "";
			ViewBag.AmountSortParm = String.IsNullOrEmpty(sortOrder) ? "amount" : "";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var bonussen = await GetBonusIndexModelQueryable();

			if(!String.IsNullOrEmpty(searchString))
				bonussen = bonussen.Where(s => s.EmployeeName.Contains(searchString));

			switch(sortOrder) {
				case "employee":
					bonussen = bonussen.OrderByDescending(s => s.EmployeeName);
					break;
				case "date":
					bonussen = bonussen.OrderByDescending(s => s.Date);
					break;
				case "amount":
					bonussen = bonussen.OrderByDescending(s => s.Amount);
					break;
				default:
					bonussen = bonussen.OrderBy(s => s.Id);
					break;
			}
			var pageNumber = page ?? 1;

			var bonussenList = new BonusListModel {
				Bonussen = bonussen.ToPagedList(pageNumber, 15)
			};

			return View(bonussenList);
		}

		// GET: Bonus/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null)
				return NotFound();

			var bonus = await (from b in _context.Bonus
												 join e in _context.Employee on b.Employee equals e.Id
												 where b.Id == id
												 select new BonusEditModel {
													 Id = b.Id,
													 Employee = b.Employee,
													 EmployeeName = e.First_name + " " + e.Last_name,
													 Amount = b.Amount,
													 Date = b.Date,
												 }).FirstOrDefaultAsync();

			if(bonus == null)
				return NotFound();

			return View(bonus);
		}

		// GET: Bonus/Create
		public async Task<IActionResult> Create() {
			var employee = await EmployeeController.GetEmployeeModelList();
			var model = new BonusEditModel {
				Employees = employee
			};
			return View(model);
		}

		// POST: Bonus/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Employee,Date,Amount")] Bonus bonus) {
			if(ModelState.IsValid) {
				bonus.Date = DateTime.Now;
				_context.Add(bonus);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(bonus);
		}

		// GET: Bonus/Edit/5
		public async Task<IActionResult> Edit(int? id) {
			if(id == null)
				return NotFound();

			var employee = await EmployeeController.GetEmployeeModelList();

			var bonussen = await (from b in _context.Bonus
														join e in _context.Employee on b.Employee equals e.Id
														where b.Id == id
														select new BonusEditModel {
															Id = b.Id,
															Employee = b.Employee,
															EmployeeName = e.First_name + " " + e.Last_name,
															Amount = b.Amount,
															Date = b.Date,
															Employees = employee
														}).FirstOrDefaultAsync();
			if(bonussen == null)
				return NotFound();

			return View(bonussen);
		}

		// POST: Bonus/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Employee,Date,Amount")] Bonus bonus) {
			if(id != bonus.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					bonus.Date = DateTime.Now;
					_context.Update(bonus);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!BonusExists(bonus.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(bonus);
		}

		// GET: Bonus/Delete/5
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}

			var bonus = await (from b in _context.Bonus
												 join e in _context.Employee on b.Employee equals e.Id
												 where b.Id == id
												 select new BonusEditModel {
													 Id = b.Id,
													 Employee = b.Employee,
													 EmployeeName = e.First_name + " " + e.Last_name,
													 Amount = b.Amount,
													 Date = b.Date,
												 }).FirstOrDefaultAsync();

			if(bonus == null) {
				return NotFound();
			}

			return View(bonus);
		}

		// POST: Bonus/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var bonus = await _context.Bonus.FindAsync(id);
			_context.Bonus.Remove(bonus);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool BonusExists(int id) {
			return _context.Bonus.Any(e => e.Id == id);
		}
	}
}
