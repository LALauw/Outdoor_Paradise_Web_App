using System;
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
	public class ProductForecastController : Controller {
		private readonly DatabaseContext _context;

		public ProductForecastController(DatabaseContext context) {
			_context = context;
		}

		public async Task<IQueryable<Product_ForecastModel>> GetProductForecastModelQueryable() {
			var list = await (from pf in _context.Product_Forecast
																							 select new Product_ForecastModel {
																								 Product = pf.Product,
																								 Year = pf.Year,
																								 Month = pf.Month,
																								 Expected_Volume = pf.Expected_Volume
																							 }).ToListAsync();

			return list.AsQueryable();
		}

		// GET: ProductForecast
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.YearSortParm = string.IsNullOrEmpty(sortOrder) ? "year" : "";
			ViewBag.MonthSortParm = string.IsNullOrEmpty(sortOrder) ? "month" : "";
			ViewBag.EvolumeSortParm = string.IsNullOrEmpty(sortOrder) ? "expected_volume" : "";
			ViewBag.ProductSortParm = string.IsNullOrEmpty(sortOrder) ? "product" : "";

			var list = await GetProductForecastModelQueryable();

			switch(sortOrder) {
				case "year":
					list = list.OrderByDescending(s => s.Year);
					break;
				case "month":
					list = list.OrderByDescending(s => s.Month);
					break;
				case "expected_volume":
					list = list.OrderByDescending(s => s.Expected_Volume);
					break;
				case "product":
					list = list.OrderByDescending(s => s.Product);
					break;
				default:
					list = list.OrderBy(s => s.Product);
					break;
			}

			var productForecastList = new Product_ForecastListModel {
				ProductForcasts = list.ToPagedList(page ?? 1, 15)
			};

			return View(productForecastList);
		}

		public async Task<Product_ForecastDetailsModel> GetProductForecastDetails(int? product, short? year, byte? month) {
			var forecast = await (from pf in _context.Product_Forecast
														where pf.Product == product && pf.Year == year && pf.Month == month
														select new Product_ForecastDetailsModel {
															Product = pf.Product,
															Year = pf.Year,
															Month = pf.Month,
															Expected_Volume = pf.Expected_Volume
														}).FirstOrDefaultAsync();
			return forecast;
		}

		// GET: ProductForecast/Details?product=1&year=2004&month=1
		public async Task<IActionResult> Details(int? product, short? year, byte? month) {
			if(product == null || year == null || month == null)
				return NotFound();

			var detailModel = await GetProductForecastDetails(product, year, month);

			if(detailModel == null)
				return NotFound();

			return View(detailModel);
		}

		// GET: ProductForecast/Create
		[Authorize(Roles = "Admin")]
		public IActionResult Create() {
			return View(new Product_ForecastCreateModel());
		}

		// POST: ProductForecast/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Product,Year,Month,Expected_Volume")] Product_ForecastCreateModel createModel) {
			var forecast = new Product_Forecast {
				Product = createModel.Product,
				Year = createModel.Year,
				Month = createModel.Month,
				Expected_Volume = createModel.Expected_Volume
			};

			if(ModelState.IsValid) {
				_context.Add(forecast);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(createModel);
		}

		// GET: ProductForecast/Edit?product=1&year=2004&month=1
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? product, short? year, byte? month) {
			if(product == null || year == null || month == null)
				return NotFound();

			var editModel = from pf in _context.Product_Forecast
											where pf.Product == product && pf.Year == year && pf.Month == month
											select new Product_ForecastEditModel {
												Product = pf.Product,
												Year = pf.Year,
												Month = pf.Month,
												Expected_Volume = pf.Expected_Volume
											};

			if(editModel == null)
				return NotFound();

			var model = await editModel.FirstAsync();

			return View(model);
		}

		// POST: ProductForecast/Edit?product=1&year=2004&month=1
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int? product, short? year, byte? month, [Bind("Product,Year,Month,Expected_Volume")] Product_ForecastEditModel productForecastEdit) {
			var productForecast = new Product_Forecast {
				Product = productForecastEdit.Product,
				Year = productForecastEdit.Year,
				Month = productForecastEdit.Month,
				Expected_Volume = productForecastEdit.Expected_Volume
			};

			if(product != productForecast.Product || year != productForecast.Year || month != productForecast.Month)
				return NotFound();

			if(ModelState.IsValid) {
				try {
					_context.Update(productForecast);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!ProductForecastExists(productForecast.Product, productForecast.Year, productForecast.Month))
						return NotFound();
					else
						throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(productForecast);
		}

		// GET: ProductForecast/Delete?product=1&year=2004&month=1
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? product, short? year, byte? month) {
			if(product == null || year == null || month == null)
				return NotFound();

			var detailModel = await GetProductForecastDetails(product, year, month);

			if(detailModel == null)
				return NotFound();

			return View(detailModel);
		}

		// POST: ProductForecast/Delete?product=1&year=2004&month=1
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int product, short year, byte month) {
			var productForecast = await _context.Product_Forecast.FindAsync(product, year, month);
			_context.Product_Forecast.Remove(productForecast);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ProductForecastExists(int product, short year, byte month) {
			return _context.Product_Forecast.Any(pf => pf.Product == product && pf.Year == year && pf.Month == month);
		}
	}
}