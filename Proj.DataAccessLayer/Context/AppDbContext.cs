using Proj.EntityLayer.Models;
using Proj.MappingLayer.Options;
using System.Data.Entity;

namespace Proj.DataAccessLayer.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext() : base("DbConnection")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AppUserMap());
			modelBuilder.Configurations.Add(new AppUserProfileMap());
			modelBuilder.Configurations.Add(new CategoryMap());
			modelBuilder.Configurations.Add(new MovieMap());
			modelBuilder.Configurations.Add(new ProductMap());
			modelBuilder.Configurations.Add(new SaleDetailMap());
			modelBuilder.Configurations.Add(new SaleMap());
		}

		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserProfile> AppUserProfiles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<SaleDetail> SaleDetails { get; set; }
		public DbSet<Sale> Sales { get; set; }
	}
}
