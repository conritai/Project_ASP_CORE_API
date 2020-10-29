using Microsoft.EntityFrameworkCore;
using Project_ASP_CORE_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Connection
{
    public class DbConnection : DbContext
    {
        public DbConnection(DbContextOptions<DbConnection> options) : base(options) { }
        public DbSet<Customer> Employees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role_n_Permission> Role_n_Permissions { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=erp_db;Username=postgres;Password=ezio1999");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User_tbl");
                entity.HasKey(c => new { c.user_id });
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer_tbl");
                entity.HasKey(c => new { c.customer_id });
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role_tbl");
                entity.HasKey(c => new { c.role_id });
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission_tbl");
                entity.HasKey(c => new { c.permission_id });
            });

            modelBuilder.Entity<Role_n_Permission>(entity =>
            {
                entity.ToTable("")
            });
        }
    }
}
