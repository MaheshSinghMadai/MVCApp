using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;

namespace MVC.Repo
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CategoryMap(modelBuilder.Entity<Category>());
            new FoodMap(modelBuilder.Entity<Food>());

            //defining many to one relationship( 1Category : NFood)
            modelBuilder.Entity<Food>()
            .HasOne<Category>(e => e.Category)
            .WithMany(d => d.Food)
            .HasForeignKey(e => e.CatId);
        }
    }
}
