using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webAPiINZ.Model;

namespace webAPiINZ.Data
{
    public class InżContext: DbContext
    {
        public InżContext(DbContextOptions<InżContext> options) : base(options)
        {

        } 
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngrProd> IngrProds   { get; set; }
        public DbSet<Personal> Personals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredients");
            modelBuilder.Entity<Personal>().ToTable("Personals");
            modelBuilder.Entity<IngrProd>(
                eb =>
                {
                    eb.HasNoKey();
                });       

        }

    }
}
