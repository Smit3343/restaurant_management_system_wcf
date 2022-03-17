using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurant_Management
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=resDataString")
        {
            Database.SetInitializer(new UserInitializer());
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                    .HasIndex(u => u.Email)
                    .IsUnique();
        }
    }
}