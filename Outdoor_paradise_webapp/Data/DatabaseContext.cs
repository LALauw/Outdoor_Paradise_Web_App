using Microsoft.EntityFrameworkCore;
using Outdoor_paradise_webapp.Models;

namespace Outdoor_paradise_webapp.Data {
	public class DatabaseContext : DbContext {
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
		}

		public DbSet<Department> Department { get; set; }
		public DbSet<Employee> Employee { get; set; }
		public DbSet<Job> Job { get; set; }
		public DbSet<Course> Course { get; set; }
		public DbSet<GO_Training> GO_Training { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Boeker> Boeker { get; set; }
		public DbSet<Product> Product { get; set; }
		public DbSet<Product_Forecast> Product_Forecast { get; set; }
		public DbSet<Image> Image { get; set; }
		public DbSet<Reis> Reis { get; set; }
		public DbSet<Reis_uitvoering> Reis_uitvoering { get; set; }
		public DbSet<Boeking> Boeking { get; set; }
		public DbSet<Promotion> Promotion { get; set; }
		public DbSet<Campaign> Campaign { get; set; }
		public DbSet<Gids> Gids { get; set; }
		public DbSet<Excursie> Excursie { get; set; }
		public DbSet<Excursie_reis_uitvoering> Excursie_reis_uitvoering { get; set; }
		public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Medereiziger> Medereiziger { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Boeking>()
				.HasKey(pk => new { pk.Boeker, pk.Reis_uitvoering });

			modelBuilder.Entity<Product_Forecast>()
				.HasKey(pk => new { pk.Product, pk.Year, pk.Month });

			modelBuilder.Entity<Campaign>()
				.HasKey(pk => new { pk.Product, pk.Promotion });

			modelBuilder.Entity<Excursie_reis_uitvoering>()
				.HasKey(pk => new { pk.Excursie, pk.Reis_uitvoering });
		}
	}
}