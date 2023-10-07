using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
	public partial class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() {}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}


        // Instead of this method we pass the lambda in Program.cs
        // file where we specify the same code. We do this to get access to
        // connection string inside appsettings.json file which is easy in Program.cs.

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connection_string");
        //    base.OnConfiguring(optionsBuilder);
        //}


        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );  
            base.OnModelCreating(modelBuilder);
        }
    }
}

