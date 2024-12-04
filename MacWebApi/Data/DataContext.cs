using MacWebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MacWebApi.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)        
                .WithMany(c => c.Products)      
                .HasForeignKey(p => p.CategoryId); 
            modelBuilder.Entity<User>()
                .HasOne(r => r.Role)
                .WithMany(u => u.Users)
                .HasForeignKey(r => r.RoleId);
            modelBuilder.Entity<Product>()
                .HasOne(o => o.Order)
                .WithMany(p => p.Products)
                .HasForeignKey(p =>p.OrderId);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.City)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CityId);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.CreatedByUser)
                .WithMany(u => u.CreatedOrders)
                .HasForeignKey(o => o.CreatedByUserId);
            modelBuilder.Entity<Order>()
                .HasOne(o=>o.ConfirmedByUser)
                .WithMany(u => u.ConfirmedOrders)
                .HasForeignKey(o => o.ConfirmedByUserId);
            modelBuilder.Entity<City>()
                .Property(c => c.Description)
                .IsRequired(false);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }  

    }
}
