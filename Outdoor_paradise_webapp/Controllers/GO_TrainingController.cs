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
	public class GO_TrainingController : Controller {
		private readonly DatabaseContext _context;
		private EmployeeController EmployeeController;

		public GO_TrainingController(DatabaseContext context) {
			_context = context;
			EmployeeController employeeController = new EmployeeController(context);
			EmployeeController = employeeController;
		}

		public async Task<IQueryable<GO_TrainingModel>> GetTrainingModelQueryable() {
			var list = await (from gt in _context.GO_Training
												join c in _context.Course on gt.Course equals c.Id
												join e in _context.Employee on gt.Employee equals e.Id
												select new GO_TrainingModel {
													Id = gt.Id,
													Course = gt.Course,
													Employee = gt.Employee,
													CourseName = c.Name,
													EmployeeName = e.First_name + " " + e.Last_name,
													Year_taken = gt.Year_taken
												}).ToListAsync();

			return list.AsQueryable();
		}

		// GET: GO_Training
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.EmployeeSortParm = String.IsNullOrEmpty(sortOrder) ? "employee" : "";
			ViewBag.CourseSortParm = String.IsNullOrEmpty(sortOrder) ? "course" : "";
			ViewBag.YearSortParm = String.IsNullOrEmpty(sortOrder) ? "year" : "";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var trainingen = await GetTrainingModelQueryable();

			if(!String.IsNullOrEmpty(searchString)) {
				trainingen = trainingen.Where(s => s.EmployeeName.Contains(searchString)
															 || s.CourseName.Contains(searchString));
			}

			switch(sortOrder) {
				case "employee":
					trainingen = trainingen.OrderByDescending(s => s.EmployeeName);
					break;
				case "course":
					trainingen = trainingen.OrderByDescending(s => s.CourseName);
					break;
				case "year":
					trainingen = trainingen.OrderByDescending(s => s.Year_taken);
					break;
				case "yeardesc":
					trainingen = trainingen.OrderBy(s => s.Year_taken);
					break;
				default:
					trainingen = trainingen.OrderBy(s => s.Id);
					break;
			}
			var pageNumber = page ?? 1;

			var trainingenlist = new GO_TrainingListModel {
				Trainingen = trainingen.ToPagedList(pageNumber, 15)
			};

			return View(trainingenlist);
		}

		public async Task<GO_TrainingDetailsModel> GetGoTrainingDetailsModel(int? id) {
			var gO_Training = await (from g in _context.GO_Training
															 join e in _context.Employee on g.Employee equals e.Id
															 join c in _context.Course on g.Course equals c.Id
															 where g.Id == id
															 select new GO_TrainingDetailsModel {
																 Id = g.Id,
																 CourseName = c.Name,
																 employeeFullName = e.First_name + " " + e.Last_name,
																 Year_taken = g.Year_taken
															 }
															 ).FirstOrDefaultAsync();
			return gO_Training;
		}
		// GET: GO_Training/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null) {
				return NotFound();
			}

			var gO_Training = await GetGoTrainingDetailsModel(id);

			if(gO_Training == null) {
				return NotFound();
			}

			return View(gO_Training);
		}

		// GET: GO_Training/Create
		public async Task<IActionResult> Create() {
			var employee = await EmployeeController.GetEmployeeModelList();
			var courses = await _context.Course.ToListAsync();
			var model = new GO_TrainingEditModel {
				Courses = courses,
				Employees = employee
			};

			return View(model);
		}

		// POST: GO_Training/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Employee,Course,Year_taken")] GO_TrainingEditModel Training) {
			var training = new GO_Training {
				Id = Training.Id,
				Employee = Training.Employee,
				Course = Training.Course,
				Year_taken = Training.Year_taken
			};
			if(ModelState.IsValid) {
				_context.Add(training);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(training);
		}

		// GET: GO_Training/Edit/5
		public async Task<IActionResult> Edit(int? id) {
			if(id == null)
				return NotFound();

			var employee = await EmployeeController.GetEmployeeModelList();
			var courses = await _context.Course.ToListAsync();
			var gO_Training = await (from gt in _context.GO_Training
															 join c in _context.Course on gt.Course equals c.Id
															 join e in _context.Employee on gt.Employee equals e.Id
															 where gt.Id == id
															 select new GO_TrainingModel {
																 Id = gt.Id,
																 Course = gt.Course,
																 Employee = gt.Employee,
																 CourseName = c.Name,
																 EmployeeName = e.First_name + " " + e.Last_name,
																 Year_taken = gt.Year_taken
															 }).FirstOrDefaultAsync();

			var gO_Training2 = await _context.GO_Training.FindAsync(id);
			var model = new GO_TrainingEditModel {
				Id = gO_Training.Id,
				Employees = employee,
				Courses = courses,
				Year_taken = gO_Training.Year_taken,
				Employee = gO_Training.Employee,
				Course = gO_Training.Course,
				CourseName = gO_Training.CourseName,
				EmployeeName = gO_Training.EmployeeName
			};

			if(gO_Training == null)
				return NotFound();

			return View(model);
		}

		// POST: GO_Training/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Employee,Course,Year_taken")] GO_Training gO_Training) {
			if(id != gO_Training.Id)
				return NotFound();

			if(ModelState.IsValid) {
				try {
					_context.Update(gO_Training);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!GO_TrainingExists(gO_Training.Id))
						return NotFound();
					else
						throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(gO_Training);
		}

		// GET: GO_Training/Delete/5
		public async Task<IActionResult> Delete(int? id) {
			if(id == null)
				return NotFound();

			var go_training = await GetGoTrainingDetailsModel(id);

			if(go_training == null)
				return NotFound();

			return View(go_training);
		}

		// POST: GO_Training/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var gO_Training = await _context.GO_Training.FindAsync(id);
			_context.GO_Training.Remove(gO_Training);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool GO_TrainingExists(int id) {
			return _context.GO_Training.Any(e => e.Id == id);
		}
	}
}
