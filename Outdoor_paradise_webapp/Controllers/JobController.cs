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
	public class JobController : Controller {
		private readonly DatabaseContext _context;

		public JobController(DatabaseContext context) {
			_context = context;
		}

		// GET: Job
		public async Task<IActionResult> Index(string sortOrder) {
			ViewBag.CodeSortParm = String.IsNullOrEmpty(sortOrder) ? "code_desc" : "";
			ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
			ViewBag.MinSSortParm = String.IsNullOrEmpty(sortOrder) ? "mins_asc" : "";
			ViewBag.MaxSSortParm = String.IsNullOrEmpty(sortOrder) ? "maxs_desc" : "";

			var jobs = from j in _context.Job
								 select j;

			switch(sortOrder) {
				case "code_desc":
					jobs = jobs.OrderByDescending(j => j.Code);
					break;
				case "title_desc":
					jobs = jobs.OrderByDescending(j => j.Title);
					break;
				case "mins_asc":
					jobs = jobs.OrderBy(j => j.Min_salary);
					break;
				case "maxs_desc":
					jobs = jobs.OrderByDescending(j => j.Max_salary);
					break;
				default:
					jobs = jobs.OrderBy(j => j.Code);
					break;
			}

			return View(await jobs.ToListAsync());
		}

		// GET: Job/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null) {
				return NotFound();
			}

			var job = await _context.Job
					.FirstOrDefaultAsync(m => m.Id == id);
			if(job == null) {
				return NotFound();
			}

			return View(job);
		}

		// GET: Job/Create
		public IActionResult Create() {
			return View();
		}

		// POST: Job/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Code,Title,Min_salary,Max_salary")] Job job) {
			if(ModelState.IsValid) {
				_context.Add(job);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(job);
		}

		// GET: Job/Edit/5
		public async Task<IActionResult> Edit(int? id) {
			if(id == null) {
				return NotFound();
			}

			var job = await _context.Job.FindAsync(id);
			if(job == null) {
				return NotFound();
			}
			return View(job);
		}

		// POST: Job/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Title,Min_salary,Max_salary")] Job job) {
			if(id != job.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					_context.Update(job);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!JobExists(job.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(job);
		}

		// GET: Job/Delete/5
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}

			var job = await _context.Job
					.FirstOrDefaultAsync(m => m.Id == id);
			if(job == null) {
				return NotFound();
			}

			return View(job);
		}

		// POST: Job/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var job = await _context.Job.FindAsync(id);
			_context.Job.Remove(job);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool JobExists(int id) {
			return _context.Job.Any(e => e.Id == id);
		}
	}
}
