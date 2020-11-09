using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCWebApplication.DataAccess
{
    public class NewsDbContext: DbContext
    {
        public NewsDbContext() : base("DefaultConnection") { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<UserInput> UserRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}