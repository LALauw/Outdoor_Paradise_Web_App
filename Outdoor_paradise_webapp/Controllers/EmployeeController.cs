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
using X.PagedList.Mvc.Core;

namespace Outdoor_paradise_webapp.Controllers {
	[Authorize(Roles = "Admin, HRM")]
	public class EmployeeController : Controller {
		private readonly DatabaseContext _context;

		public EmployeeController(DatabaseContext context) {
			_context = context;
		}

		public async Task<List<EmployeeModel>> GetEmployeeModelList() {
			var list = await (from e in _context.Employee
												join m in _context.Employee on e.Manager equals m.Id into gj
												from submanager in gj.DefaultIfEmpty()
												join d in _context.Department on e.Department equals d.Id into gd
												from subdep in gd.DefaultIfEmpty()
												join j in _context.Job on e.Job equals j.Id into gjob
												from subjob in gjob.DefaultIfEmpty()
												select new EmployeeModel {
													Id = e.Id,
													Ssn = e.Ssn,
													Status = e.Status,
													First_name = e.First_name,
													Last_name = e.Last_name,
													Email = e.Email,
													Work_phone = e.Work_phone,
													Salary = e.Salary,
													Birth_date = e.Birth_date.ToString(),
													Manager_fname = submanager.First_name,
													Manager_lname = submanager.Last_name,
													Postition = e.Position_en,
													Job = subjob.Title,
													Department = subdep.Name
												}).ToListAsync();

			return list;
		}

		public async Task<IQueryable<EmployeeModel>> GetEmployeeModelQueryable() {
			var list = await GetEmployeeModelList();

			return list.AsQueryable();
		}

		// GET: Employee
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "last_name" : "";
			ViewBag.IdSortParm = String.IsNullOrEmpty(sortOrder) ? "Id" : "";
			ViewBag.FnameSortParm = String.IsNullOrEmpty(sortOrder) ? "Fname" : "";
			ViewBag.LnameSortParm = String.IsNullOrEmpty(sortOrder) ? "Lname" : "";
			ViewBag.BirthSortParm = String.IsNullOrEmpty(sortOrder) ? "Birth" : "";
			ViewBag.SalarySortParm = String.IsNullOrEmpty(sortOrder) ? "Salary" : "";
			ViewBag.JobSortParm = String.IsNullOrEmpty(sortOrder) ? "Job" : "";
			ViewBag.PositionSortParm = String.IsNullOrEmpty(sortOrder) ? "Position" : "";
			ViewBag.DepartmentSortParm = String.IsNullOrEmpty(sortOrder) ? "Department" : "";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var list = await GetEmployeeModelQueryable();

			if(!String.IsNullOrEmpty(searchString)) {
				list = list.Where(s => s.Last_name.Contains(searchString)
															 || s.First_name.Contains(searchString));
			}

			switch(sortOrder) {
				case "last_name":
					list = list.OrderByDescending(s => s.Last_name);
					break;
				case "Id":
					list = list.OrderByDescending(s => s.Id);
					break;
				case "Fname":
					list = list.OrderByDescending(s => s.First_name);
					break;
				case "Lname":
					list = list.OrderByDescending(s => s.Last_name);
					break;
				case "Birth":
					list = list.OrderByDescending(s => s.Birth_date);
					break;
				case "Salary":
					list = list.OrderByDescending(s => s.Salary);
					break;
				case "Job":
					list = list.OrderByDescending(s => s.Job);
					break;
				case "Position":
					list = list.OrderByDescending(s => s.Department);
					break;
				case "Department":
					list = list.OrderByDescending(s => s.Department);
					break;
				default:
					list = list.OrderBy(s => s.Id);
					break;
			}

			var pageNumber = page ?? 1;
			var employeeslist = new EmployeeListModel {
				Employees = list.ToPagedList(pageNumber, 15)
			};

			return View(employeeslist);
		}

		public async Task<EmployeeDetailsModel> GetEmployeeDetails(int? id) {
			var employee = await (from e in _context.Employee
														join m in _context.Employee on e.Manager equals m.Id into gj
														from submanager in gj.DefaultIfEmpty()
														join d in _context.Department on e.Department equals d.Id into gd
														from subdep in gd.DefaultIfEmpty()
														join j in _context.Job on e.Job equals j.Id into gjob
														from subjob in gjob.DefaultIfEmpty()
														where e.Id == id
														select new EmployeeDetailsModel {
															Id = e.Id,
															Ssn = e.Ssn,
															Status = e.Status,
															Street = e.Street,
															City = e.City,
															State = e.State,
															Zip_code = e.Zip_code,
															Fax = e.Fax,
															Sex = e.Sex,
															JobName = subjob.Title,
															First_name = e.First_name,
															Last_name = e.Last_name,
															Email = e.Email,
															Work_phone = e.Work_phone,
															Salary = e.Salary,
															Birth_date = e.Birth_date.ToString(),
															Termination_date = e.Termination_date.ToString(),
															Bene_life_ins = e.Bene_life_ins,
															Bene_day_care = e.Bene_day_care,
															Bene_health_ins = e.Bene_health_ins,
															Position_en = e.Position_en,
															Extension = e.Extension,
															Acces_level = e.Acces_level,
															Manager_fname = submanager.First_name,
															Manager_lname = submanager.Last_name,
															Department = subdep.Name
														}).FirstOrDefaultAsync();
			return employee;
		}
		// GET: Employee/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null) {
				return NotFound();
			}
			var employee = await GetEmployeeDetails(id);

			if(employee == null) {
				return NotFound();
			}
			return View(employee);
		}

		// GET: Employee/Create
		public async Task<IActionResult> Create() {
			var departments = await _context.Department.ToListAsync();
			var jobs = await _context.Job.ToListAsync();
			var managers = await (from e in _context.Employee
														join m in _context.Employee on e.Manager equals m.Id
														select new Manager {
															Id = m.Id,
															First_name = m.First_name,
															Last_name = m.Last_name
														}).Distinct().ToListAsync();

			var model = new EmployeeCreateModel {
				Departments = departments,
				Jobs = jobs,
				Managers = managers
			};
			return View(model);
		}

		// POST: Employee/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,First_name,Last_name,Street,City,State,Zip_code,Email,Fax,Sex,Work_phone,Status,Ssn,Salary,Date_hired,Termination_date,Birth_date,Bene_health_ins,Bene_life_ins,Bene_day_care,Position_en,Extension,Acces_level,Manager,Department,Sales_branch,Job")] EmployeeCreateModel employeeCreateModel) {
			var Employee = new Employee {
				Id = employeeCreateModel.Id,
				First_name = employeeCreateModel.First_name,
				Last_name = employeeCreateModel.Last_name,
				Street = employeeCreateModel.Street,
				City = employeeCreateModel.City,
				State = employeeCreateModel.State,
				Zip_code = employeeCreateModel.Zip_code,
				Email = employeeCreateModel.Email,
				Fax = employeeCreateModel.Fax,
				Sex = employeeCreateModel.Sex,
				Work_phone = employeeCreateModel.Work_phone,
				Status = employeeCreateModel.Status,
				Ssn = employeeCreateModel.Ssn,
				Salary = employeeCreateModel.Salary,
				Date_hired = employeeCreateModel.Date_hired,
				Termination_date = employeeCreateModel.Termination_date,
				Birth_date = employeeCreateModel.Birth_date,
				Bene_health_ins = employeeCreateModel.Bene_health_ins,
				Bene_day_care = employeeCreateModel.Bene_day_care,
				Bene_life_ins = employeeCreateModel.Bene_life_ins,
				Position_en = employeeCreateModel.Position_en,
				Extension = employeeCreateModel.Extension,
				Acces_level = employeeCreateModel.Acces_level,
				Manager = employeeCreateModel.Manager,
				Department = employeeCreateModel.Department,
				Job = employeeCreateModel.Job
			};

			if(ModelState.IsValid) {
				_context.Add(Employee);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(employeeCreateModel);
		}

		// GET: Employee/Edit/5
		public async Task<IActionResult> Edit(int? id) {
			if(id == null)
				return NotFound();

			var departments = await _context.Department.ToListAsync();

			var jobs = await _context.Job.ToListAsync();

			var employees = await GetEmployeeModelList();

			var managers = await (from e in _context.Employee
														join m in _context.Employee on e.Manager equals m.Id
														select new Manager {
															Id = m.Id, First_name = m.First_name, Last_name = m.Last_name
														}).Distinct().ToListAsync();

			var employee = from e in _context.Employee
										 join m in _context.Employee on e.Manager equals m.Id into gj
										 from submanager in gj.DefaultIfEmpty()
										 join d in _context.Department on e.Department equals d.Id into gd
										 from subdep in gd.DefaultIfEmpty()
										 join j in _context.Job on e.Job equals j.Id into gjob
										 from subjob in gjob.DefaultIfEmpty()
										 where e.Id == id
										 select new EmployeeEditModel {
											 Id = e.Id,
											 Ssn = e.Ssn,
											 Status = e.Status,
											 Street = e.Street,
											 City = e.City,
											 State = e.State,
											 Zip_code = e.Zip_code,
											 Fax = e.Fax,
											 Sex = e.Sex,
											 JobName = subjob.Title,
											 Job = subjob.Id,
											 Manager = submanager.Id,
											 DepartmentNumber = subdep.Id,
											 First_name = e.First_name,
											 Last_name = e.Last_name,
											 Email = e.Email,
											 Work_phone = e.Work_phone,
											 Salary = e.Salary,
											 Birth_date = e.Birth_date.ToString(),
											 Termination_date = e.Termination_date.ToString(),
											 Bene_life_ins = e.Bene_life_ins,
											 Bene_day_care = e.Bene_day_care,
											 Bene_health_ins = e.Bene_health_ins,
											 Position_en = e.Position_en,
											 Extension = e.Extension,
											 Acces_level = e.Acces_level,
											 Departments = departments,
											 Jobs = jobs,
											 Managers = managers,
											 Employees = employees,
											 Manager_fname = submanager.First_name,
											 Manager_lname = submanager.Last_name,
											 Department = subdep.Name
										 };



			if(employee == null) {
				return NotFound();
			}
			var model = await employee.FirstAsync();
			return View(model);
		}

		// POST: Employee/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,First_name,Last_name,Street,City,State,Zip_code,Email,Fax,Sex,Work_phone,Status,Ssn,Salary,Date_hired,Termination_date,Birth_date,Bene_health_ins,Bene_life_ins,Bene_day_care,Position_en,Extension,Acces_level,Manager,DepartmentNumber,Job")] EmployeeEditModel employeeEdit) {

			var employee = new Employee {
				Id = id,
				First_name = employeeEdit.First_name,
				Last_name = employeeEdit.Last_name,
				Street = employeeEdit.Street,
				City = employeeEdit.City,
				State = employeeEdit.State,
				Zip_code = employeeEdit.Zip_code,
				Email = employeeEdit.Email,
				Fax = employeeEdit.Fax,
				Sex = employeeEdit.Sex,
				Work_phone = employeeEdit.Work_phone,
				Status = employeeEdit.Status,
				Ssn = employeeEdit.Ssn,
				Salary = employeeEdit.Salary,
				Date_hired = employeeEdit.Date_hired == null ? DateTime.Now : DateTime.Parse(employeeEdit.Date_hired),
				Termination_date = employeeEdit.Termination_date == null ? DateTime.Now : DateTime.Parse(employeeEdit.Termination_date),
				Birth_date = employeeEdit.Birth_date == null ? DateTime.Now : DateTime.Parse(employeeEdit.Birth_date),
				Bene_life_ins = employeeEdit.Bene_health_ins,
				Bene_health_ins = employeeEdit.Bene_health_ins,
				Bene_day_care = employeeEdit.Bene_day_care,
				Position_en = employeeEdit.Position_en,
				Extension = employeeEdit.Extension,
				Acces_level = employeeEdit.Acces_level,
				Manager = employeeEdit.Manager,
				Job = employeeEdit.Job,
				Department = employeeEdit.DepartmentNumber
			};


			if(id != employee.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					_context.Update(employee);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!EmployeeExists(employee.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(employee);
		}

		// GET: Employee/Delete/5
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}

			var employee = await GetEmployeeDetails(id);

			if(employee == null) {
				return NotFound();
			}

			return View(employee);
		}

		// POST: Employee/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var employee = await _context.Employee.FindAsync(id);
			_context.Employee.Remove(employee);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool EmployeeExists(int id) {
			return _context.Employee.Any(e => e.Id == id);
		}
	}
}
