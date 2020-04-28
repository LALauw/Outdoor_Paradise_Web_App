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
	public class ImageController : Controller {
		private readonly DatabaseContext _context;

		public ImageController(DatabaseContext context) {
			_context = context;
		}

		public async Task<IQueryable<Image>> GetImageQueryable() {
			var list = await(from i in _context.Image
											 select new Image {
												 Id = i.Id,
												 Name = i.Name,
												 Product_id = i.Product_id,
												 Imagepath = i.Imagepath
											 }).ToListAsync();

			return list.AsQueryable();
		}

		// GET: Image
		public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.IdSortParm = string.IsNullOrEmpty(sortOrder) ? "id" : "";
			ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name" : "";
			ViewBag.ProductSortParm = string.IsNullOrEmpty(sortOrder) ? "product" : "";
			ViewBag.IPathSortParm = string.IsNullOrEmpty(sortOrder) ? "imagepath" : "";

			if(searchString != null)
				page = 1;
			else
				searchString = currentFilter;

			ViewBag.CurrentFilter = searchString;

			var list = await GetImageQueryable();

			if(!string.IsNullOrEmpty(searchString))
				list = list.Where(s => s.Name.Contains(searchString));

			switch(sortOrder) {
				case "id":
					list = list.OrderByDescending(p => p.Id);
					break;
				case "name":
					list = list.OrderByDescending(p => p.Name);
					break;
				case "product":
					list = list.OrderByDescending(p => p.Product_id);
					break;
				case "imagepath":
					list = list.OrderByDescending(p => p.Imagepath);
					break;
				default:
					list = list.OrderBy(s => s.Id);
					break;
			}

			var pageNumber = page ?? 1;
			var imageList = new ImageListModel {
				Images = list.ToPagedList(pageNumber, 15)
			};

			return View(imageList);
		}

		public async Task<Image> GetImageDetails(int? id) {
			var image = await (from i in _context.Image
												 where i.Id == id
												 select new Image {
													 Id = i.Id,
													 Name = i.Name,
													 Product_id = i.Product_id,
													 Imagepath = i.Imagepath
												 }).FirstOrDefaultAsync();
			return image;
		}

		// GET: Image/Details/5
		public async Task<IActionResult> Details(int? id) {
			if(id == null)
				return NotFound();

			var image = await GetImageDetails(id);

			if(image == null)
				return NotFound();

			return View(image);
		}

		// GET: Image/Create
		[Authorize(Roles = "Admin")]
		public IActionResult Create() {
			return View(new Image());
		}

		// POST: Image/Create
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Product_id,Imagepath")] Image imageCreateModel) {
			var image = new Image {
				Id = imageCreateModel.Id,
				Name = imageCreateModel.Name,
				Product_id = imageCreateModel.Product_id,
				Imagepath = imageCreateModel.Imagepath
			};

			if(ModelState.IsValid) {
				_context.Add(image);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(imageCreateModel);
		}

		// GET: Image/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id) {
			if(id == null) {
				return NotFound();
			}

			var image = await _context.Image.FindAsync(id);
			if(image == null) {
				return NotFound();
			}
			return View(image);
		}

		// POST: Image/Edit/5
		[Authorize(Roles = "Admin")]
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Product_id,Imagepath")] Image imageEdit) {
			var image = new Image {
				Id = imageEdit.Id,
				Name = imageEdit.Name,
				Product_id = imageEdit.Product_id,
				Imagepath = imageEdit.Imagepath,
			};

			if(id != image.Id)
				return NotFound();

			if(ModelState.IsValid) {
				try {
					_context.Update(image);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!ProductExists(image.Id))
						return NotFound();
					else
						throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(image);
		}

		// GET: Image/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id) {
			if(id == null)
				return NotFound();

			var image = await GetImageDetails(id);

			if(image == null)
				return NotFound();

			return View(image);
		}

		// POST: Image/Delete/5
		[Authorize(Roles = "Admin")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var image = await _context.Image.FindAsync(id);
			_context.Image.Remove(image);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ProductExists(int id) {
			return _context.Image.Any(p => p.Id == id);
		}
	}
}
