using System;
using System.Collections.Generic;
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
	public class CampaignController : Controller {
		private readonly DatabaseContext _context;

		public CampaignController(DatabaseContext context) {
			_context = context;
		}

		public async Task<IQueryable<Campaign>> GetCampaignQueryable() {
			var list = await (from c in _context.Campaign
												select new Campaign {
													Product = c.Product,
													Promotion = c.Promotion,
													Discount = Math.Truncate(Convert.ToDouble(c.Discount.GetValueOrDefault(0)) * 100) / 100
												}).ToListAsync();
			return list.AsQueryable();
		}

		// GET: Campaign
		public async Task<IActionResult> Index(string sortOrder, int? page) {
			ViewBag.CurrentSort = sortOrder;
			ViewBag.ProductSortParm = string.IsNullOrEmpty(sortOrder) ? "product" : "";
			ViewBag.PromotionSortParm = string.IsNullOrEmpty(sortOrder) ? "promotion" : "";
			ViewBag.DiscountSortParm = string.IsNullOrEmpty(sortOrder) ? "discount" : "";

			var list = await GetCampaignQueryable();

			switch(sortOrder) {
				case "product":
					list = list.OrderByDescending(p => p.Product);
					break;
				case "promotion":
					list = list.OrderByDescending(p => p.Promotion);
					break;
				case "discount":
					list = list.OrderByDescending(p => p.Discount);
					break;
				default:
					list = list.OrderBy(s => s.Product);
					break;
			}

			var pageNumber = page ?? 1;
			var campaignList = new CampaignListModel {
				Campaigns = list.ToPagedList(pageNumber, 15)
			};

			return View(campaignList);
		}

		public async Task<Campaign> GetCampaignDetails(int? product, short? promotion) {
			var campaign = await (from c in _context.Campaign
														where c.Product == product && c.Promotion == promotion
														select new Campaign {
															Product = c.Product,
															Promotion = c.Promotion,
															Discount = Math.Truncate(Convert.ToDouble(c.Discount.GetValueOrDefault(0)) * 100) / 100
														}).FirstOrDefaultAsync();
			return campaign;
		}

		// GET: Campaign/Details/5
		public async Task<IActionResult> Details(int? product, short? promotion) {
			if(product == null || promotion == null)
				return NotFound();

			var campaign = await GetCampaignDetails(product, promotion);

			if(campaign == null)
				return NotFound();

			return View(campaign);
		}

		// GET: Campaign/Create
		public IActionResult Create() {
			return View(new Campaign());
		}

		// POST: Campaign/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Product,Promotion,Discount")] Campaign campaignCreate) {
			var ctxCampaign = new Campaign {
				Product = campaignCreate.Product,
				Promotion = campaignCreate.Promotion,
				Discount = campaignCreate.Discount,
			};

			if(ModelState.IsValid) {
				_context.Add(ctxCampaign);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(campaignCreate);
		}

		// GET: Campaign/Edit/5
		public async Task<IActionResult> Edit(int? product, short? promotion) {
			if(product == null || promotion == null)
				return NotFound();

			var campaignModel = from c in _context.Campaign
													where c.Product == product && c.Promotion == promotion
													select new Campaign {
														Product = c.Product,
														Promotion = c.Promotion,
														Discount = c.Discount,
													};

			if(campaignModel == null)
				return NotFound();

			var model = await campaignModel.FirstAsync();

			return View(model);
		}

		// POST: Campaign/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int? product, short? promotion, [Bind("Product,Promotion,Discount")] Campaign campaign) {
			var campaignModel = new Campaign {
				Product = campaign.Product,
				Promotion = campaign.Promotion,
				Discount = campaign.Discount,
			};

			if(product != campaignModel.Product || promotion != campaignModel.Promotion)
				return NotFound();

			if(ModelState.IsValid) {
				try {
					_context.Update(campaignModel);
					await _context.SaveChangesAsync();
				}
				catch(DbUpdateConcurrencyException) {
					if(!CampaignExists(campaignModel.Product, campaignModel.Promotion))
						return NotFound();
					else
						throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(campaignModel);
		}

		// GET: Product/Delete/5
		public async Task<IActionResult> Delete(int? product, short? promotion) {
			if(product == null || promotion == null)
				return NotFound();

			var campaignModel = await GetCampaignDetails(product, promotion);

			if(campaignModel == null)
				return NotFound();

			return View(campaignModel);
		}

		// POST: Product/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int? product, short? promotion) {
			var campaign = await _context.Campaign.FindAsync(product, promotion);
			_context.Campaign.Remove(campaign);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool CampaignExists(int product, short promotion) {
			return _context.Campaign.Any(c => c.Product == product && c.Promotion == promotion);
		}
	}
}
