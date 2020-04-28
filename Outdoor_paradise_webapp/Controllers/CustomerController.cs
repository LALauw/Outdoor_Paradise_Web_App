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
	public class CustomerController : Controller {
		private readonly DatabaseContext _context;

		public CustomerController(DatabaseContext context) {
			_context = context;
		}

		// GET: Customer
		public async Task<IActionResult> Index() {
			return View(await _context.Customer.ToListAsync());
		}

		// GET: Customer/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null) {
				return NotFound();
			}

			var customer = await _context.Customer
					.FirstOrDefaultAsync(m => m.Id == id);
			if(customer == null) {
				return NotFound();
			}

			return View(customer);
		}

		// GET: Customer/Create
		[Authorize(Roles = "Admin")]
		public IActionResult Create() {
			return View();
		}

		// POST: Customer/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,First_name,Last_name,Email,Address,State,Zip,Phone,Company_name,discount,Max_quantity_order,Typecode,Manager,Username")] Customer customer) {
			if(ModelState.IsValid) {
				_context.Add(customer);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(customer);
		}

		// GET: Customer/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null) {
				return NotFound();
			}

			var customer = await _context.Customer.FindAsync(id);
			if(customer == null) {
				return NotFound();
			}
			return View(customer);
		}

		// POST: Customer/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,First_name,Last_name,Email,Address,State,Zip,Phone,Company_name,discount,Max_quantity_order,Typecode,Manager,Username")] Customer customer) {
			if(id != customer.Id) {
				return NotFound();
			}

			if(ModelState.IsValid) {
				try {
					_context.Update(customer);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!CustomerExists(customer.Id)) {
						return NotFound();
					}
					else {
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(customer);
		}

		// GET: Customer/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null) {
				return NotFound();
			}

			var customer = await _context.Customer
					.FirstOrDefaultAsync(m => m.Id == id);
			if(customer == null) {
				return NotFound();
			}

			return View(customer);
		}

		// POST: Customer/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var customer = await _context.Customer.FindAsync(id);
			_context.Customer.Remove(customer);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool CustomerExists(int id) {
			return _context.Customer.Any(e => e.Id == id);
		}
	}
}
