using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ktra.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Tags> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 1,
                Title = "Rau",
                Description = "Re"

            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 2,
                Title = "Ca",
                Description = "Tuoi"

            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 3,
                Title = "Thit",
                Description = "Ngon"

            });
            modelBuilder.Entity<PostsTag>().HasKey(potag => new { potag.PostsId, potag.TagsId });
            modelBuilder.Entity<Tags>().HasData(new Tags
            {
                Id = 1,
                Title = "Gao",
                Description = "Thom"

            });
            modelBuilder.Entity<Tags>().HasData(new Tags
            {
                Id = 2,
                Title = "My",
                Description = "Ngon"

            });
            modelBuilder.Entity<Tags>().HasData(new Tags
            {
                Id = 3,
                Title = "Lua My",
                Description = "Bo"

            });
        }
    }
}
