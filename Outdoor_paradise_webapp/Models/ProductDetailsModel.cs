namespace Outdoor_paradise_webapp.Models {
	public class ProductDetailsModel {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public char? Category { get; set; }
		public string Introduction_date { get; set; }
		public double? Price { get; set; }
		public double? Production_cost { get; set; }
		public double? Profit_margin { get; set; }
		public string Color { get; set; }
		public string Size { get; set; }
		public int? Product_type { get; set; }
	}
}
