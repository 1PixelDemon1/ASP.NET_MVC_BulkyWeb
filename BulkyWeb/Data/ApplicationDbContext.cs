using System;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
	partial class ApplicationDbContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

