using System;

namespace Outdoor_paradise_webapp.Models {
	public class Product_Forecast {
		public int Product { get; set; }
		public short Year { get; set; }
		public byte Month { get; set; }
		public int Expected_Volume { get; set; }
	}
}
