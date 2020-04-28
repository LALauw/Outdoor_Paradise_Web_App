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
	public class ProductController : Controller {
		private readonly DatabaseContext _context;

		public ProductController(DatabaseContext context) {
			_context = context;
		}

		public async Task<IQueryable<ProductModel>> GetProductModelQueryable() {
			var list = await (from p in _context.Product
												select new ProductModel {
													Id = p.Id,
													Name = p.Name,
													Description = p.Description,
													Category = p.Category,
													Introduction_date = p.Introduction_date.ToString(),
													Price = p.Price,
													Production_cost = p.Production_cost,
													Profit_margin = p.Profit_margin,
													Color = p.Color,
													Size = p.Size
												}).ToListAsync();

			return list.AsQueryable();
		}

		// GET: Product
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.IdSortParm = sortOrder == "id" ? "id_desc" : "id";
			ViewBag.NameSortParm = sortOrder == "name" ? "name_desc" : "name";
			ViewBag.DescriptionSortParm = sortOrder == "description" ? "description_desc" : "description";
			ViewBag.CategorySortParm = sortOrder == "category" ? "category_desc" : "category";
			ViewBag.IdateSortParm = sortOrder == "intro_date" ? "intro_date_desc" : "intro_date";
			ViewBag.PcostSortParm = sortOrder == "prod_cost" ? "prod_cost_desc" : "prod_cost";
			ViewBag.PriceSortParm = sortOrder == "price" ? "price_desc" : "price";
			ViewBag.PmarginSortParm = sortOrder == "profit_margin" ? "profit_margin_desc" : "profit_margin";
			ViewBag.ColorSortParm = sortOrder == "color" ? "color_desc" : "color";
			ViewBag.SizeSortParm = sortOrder == "size" ? "size_desc" : "size";
			ViewBag.PTypeSortParm = sortOrder == "prod_type" ? "prod_type_desc" : "prod_type";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var list = await GetProductModelQueryable();

			if(!string.IsNullOrEmpty(searchString))
				list = list.Where(s => s.Name.Contains(searchString));

			if(sortOrder != null) {
				if(sortOrder.StartsWith("id"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Id) : list.OrderBy(p => p.Id);
				else if(sortOrder.StartsWith("name"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Name) : list.OrderBy(p => p.Name);
				else if(sortOrder.StartsWith("description"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Description) : list.OrderBy(p => p.Description);
				else if(sortOrder.StartsWith("category"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Category) : list.OrderBy(p => p.Category);
				else if(sortOrder.StartsWith("intro_date"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Introduction_date) : list.OrderBy(p => p.Introduction_date);
				else if(sortOrder.StartsWith("prod_cost"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Production_cost) : list.OrderBy(p => p.Production_cost);
				else if(sortOrder.StartsWith("price"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Price) : list.OrderBy(p => p.Price);
				else if(sortOrder.StartsWith("profit_margin"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Profit_margin) : list.OrderBy(p => p.Profit_margin);
				else if(sortOrder.StartsWith("color"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Color) : list.OrderBy(p => p.Color);
				else if(sortOrder.StartsWith("size"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Size) : list.OrderBy(p => p.Size);
				else if(sortOrder.StartsWith("prod_type"))
					list = sortOrder.EndsWith("desc") ? list.OrderByDescending(p => p.Product_type) : list.OrderBy(p => p.Product_type);
			}
			else
				list = list.OrderBy(p => p.Id);

			var pageNumber = page ?? 1;
			var productlist = new ProductListModel {
				Products = list.ToPagedList(pageNumber, 15)
			};

			return View(productlist);
		}

		public async Task<ProductDetailsModel> GetProductDetails(int? id) {
			var product = await (from p in _context.Product
													 where p.Id == id
													 select new ProductDetailsModel {
														 Id = p.Id,
														 Name = p.Name,
														 Description = p.Description,
														 Category = p.Category,
														 Introduction_date = p.Introduction_date.ToString(),
														 Price = p.Price,
														 Production_cost = p.Production_cost,
														 Profit_margin = p.Profit_margin,
														 Color = p.Color,
														 Size = p.Size,
														 Product_type = p.Product_type
													 }).FirstOrDefaultAsync();
			return product;
		}
		// GET: Product/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null)
				return NotFound();

			var product = await GetProductDetails(id);

			if(product == null)
				return NotFound();

			return View(product);
		}

		// GET: Product/Create
		[Authorize(Roles = "Admin")]
		public IActionResult Create() {
			return View(new ProductCreateModel());
		}

		// POST: Product/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Description,Category,Introduction_date,Price,Production_cost,Profit_margin,Color,Size,Product_type")] ProductCreateModel productCreateModel) {
			var product = new Product {
				Id = productCreateModel.Id,
				Name = productCreateModel.Name,
				Description = productCreateModel.Description,
				Category = productCreateModel.Category,
				Introduction_date = productCreateModel.Introduction_date,
				Price = productCreateModel.Price,
				Production_cost = productCreateModel.Production_cost,
				Profit_margin = productCreateModel.Profit_margin,
				Color = productCreateModel.Color,
				Size = productCreateModel.Size,
				Product_type = productCreateModel.Product_type
			};

			if(ModelState.IsValid) {
				_context.Add(product);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(productCreateModel);
		}

		// GET: Product/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null)
				return NotFound();

			var product = from p in _context.Product
										where p.Id == id
										select new ProductModel {
											Id = p.Id,
											Name = p.Name,
											Description = p.Description,
											Category = p.Category,
											Introduction_date = p.Introduction_date.ToString(),
											Price = p.Price,
											Production_cost = p.Production_cost,
											Profit_margin = p.Profit_margin,
											Color = p.Color,
											Size = p.Size,
											Product_type = p.Product_type
										};

			if(product == null)
				return NotFound();

			var model = await product.FirstAsync();

			return View(model);
		}

		// POST: Product/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Category,Introduction_date,Price,Production_cost,Profit_margin,Color,Size,Product_type")] ProductModel productModel) {
			var product = new Product {
				Id = productModel.Id,
				Name = productModel.Name,
				Description = productModel.Description,
				Category = productModel.Category,
				Introduction_date = productModel.Introduction_date == null ? DateTime.Now : DateTime.Parse(productModel.Introduction_date),
				Price = productModel.Price,
				Production_cost = productModel.Production_cost,
				Profit_margin = productModel.Profit_margin,
				Color = productModel.Color,
				Size = productModel.Size,
				Product_type = productModel.Product_type
			};

			if(id != product.Id)
				return NotFound();

			if(ModelState.IsValid) {
				try {
					_context.Update(product);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!ProductExists(product.Id))
						return NotFound();
					else
						throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(product);
		}

		// GET: Product/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null)
				return NotFound();

			var product = await GetProductDetails(id);

			if(product == null)
				return NotFound();

			return View(product);
		}

		// POST: Product/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var product = await _context.Product.FindAsync(id);
			_context.Product.Remove(product);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ProductExists(int id) {
			return _context.Product.Any(p => p.Id == id);
		}
	}
}