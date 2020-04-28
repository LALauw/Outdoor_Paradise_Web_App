using System;

namespace Outdoor_paradise_webapp.Models {
	public class Promotion {
		public short Id { get; set; }
		public DateTime Date_start { get; set; }
		public DateTime Date_end { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }
	}
}
