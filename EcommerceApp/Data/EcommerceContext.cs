using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcommerceApp.Models;

namespace EcommerceApp.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext (DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
