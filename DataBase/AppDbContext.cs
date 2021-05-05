using FakeXiecheng.Moldes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.DataBase
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<TouristRoute>().HasData(new TouristRoute()
            {
                Id = Guid.NewGuid(),
                Title = "ceshititle",
                Descrption = "shuoming",
                OriginalPrice = 0,
                CreateTime = DateTime.UtcNow
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
