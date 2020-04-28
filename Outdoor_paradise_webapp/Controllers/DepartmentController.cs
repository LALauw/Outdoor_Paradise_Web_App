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
	[Authorize(Roles = "Admin, HRM")]
	public class DepartmentController : Controller {
		private readonly DatabaseContext _context;

		public DepartmentController(DatabaseContext context) {
			_context = context;
		}

		// GET: Department
		public async Task<IActionResult> Index() {
			var department = await (from d in _context.Department
															join e in _context.Employee on d.Manager equals e.Id
															select new DepartmentDetailsModel {
																Id = d.Id,
																Name = d.Name,
																Manager = d.Manager,
																EmployeeModel = new EmployeeModel {
																	First_name = e.First_name,
																	Last_name = e.Last_name,
																}
															}).ToListAsync();

			return View(department);
		}

		// GET: Department/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null) {
				return NotFound();
			}

			var department = await (from d in _context.Department
															join e in _context.Employee on d.Manager equals e.Id
															where d.Id == id
															select new DepartmentDetailsModel {
																Id = d.Id,
																Name = d.Name,
																Manager = d.Manager,
																EmployeeModel = new EmployeeModel {
																	First_name = e.First_name,
																	Last_name = e.Last_name,
																}
															}).FirstOrDefaultAsync();
			if(department == null) {
				return NotFound();
			}

			return View(department);
		}

		// GET: Department/Create
		[Authorize(Roles = "Admin")]
		public IActionResult Create() {
			return View();
		}

		// POST: Department/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Manager")] Department department) {
			if(ModelState.IsValid) {
				_context.Add(department);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(department);
		}

		// GET: Department/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null) {
				return NotFound();
			}

			var department = await _context.Department.FindAsync(id);
			if(department == null) {
				return NotFound();
			}
			return View(department);
		}

		// POST: Department/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Manager")] Department department) {
			if(id != department.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					_context.Update(department);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!DepartmentExists(department.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(department);
		}


		// GET: Department/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}

			var department = await _context.Department
					.FirstOrDefaultAsync(m => m.Id == id);
			if(department == null) {
				return NotFound();
			}

			return View(department);
		}

		// POST: Department/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var department = await _context.Department.FindAsync(id);
			_context.Department.Remove(department);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool DepartmentExists(int id) {
			return _context.Department.Any(e => e.Id == id);
		}
	}
}
