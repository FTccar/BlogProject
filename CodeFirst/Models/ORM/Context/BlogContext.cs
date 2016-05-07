using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CodeFirst.Models.Data;
using CodeFirst.Models.ORM.Entity;

namespace CodeFirst.Models.ORM.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-1TVRRF4\\FERDI;Database=OnlineBlog;UID=sa;PWD=27412946634";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // databas'e çoğul yazılmaması için.
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<SiteMenu> SiteMenus{ get; set; }
    }
}