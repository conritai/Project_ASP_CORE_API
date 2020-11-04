using Microsoft.EntityFrameworkCore;
using Project_ASP_CORE_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Connection
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role_n_Permission> Role_n_Permissions { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=erp_db;Username=postgres;Password=ezio1999");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            //configure
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user_tbl");
                entity.HasKey(c => new { c.User_id });
                entity.Property(c => c.User_id)
                    .HasColumnName("user_id");

                entity.Property(c => c.Username)
                    .HasColumnName("username");
                
                entity.Property(c => c.Password)
                    .HasColumnName("password");
                
                entity.Property(c => c.Phone_number)
                    .HasColumnName("phone_number");
                
                entity.Property(c => c.Email)
                    .HasColumnName("email");
                
                entity.Property(c => c.Full_name)
                    .HasColumnName("full_name");
                
                entity.Property(c => c.Role_id)
                    .HasColumnName("role_id");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer_tbl");
                entity.HasKey(c => new { c.Customer_id });
                entity.Property(c => c.Customer_id)
                    .HasColumnName("customer_id");
                entity.Property(c => c.Full_name)
                    .HasColumnName("full_name");
                entity.Property(c => c.Phone_number)
                    .HasColumnName("phone_number");
                entity.Property(c => c.Email)
                    .HasColumnName("email");
                entity.Property(c => c.Submit_on)
                    .HasColumnName("submit_on");
                entity.Property(c => c.Domain_name)
                    .HasColumnName("domain_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role_tbl");
                entity.HasKey(c => new { c.Role_id });
                entity.Property(c => c.Role_id)
                    .HasColumnName("role_id");
                entity.Property(x => x.Create_role_at)
                    .HasColumnName("create_role_at");
                entity.Property(c => c.Update_role_at)
                    .HasColumnName("update_role_at");
                entity.Property(c => c.Role_name)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission_tbl");
                entity.HasKey(c => new { c.Permission_id });
                entity.Property(x => x.Permission_id)
                    .HasColumnName("permission_id");
                entity.Property(c => c.Permission_name)
                    .HasColumnName("permission_name");
                entity.Property(c => c.Description)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Role_n_Permission>(entity =>
            {
                entity.ToTable("role_permission_tbl");
                entity.HasKey(c => new { c.Permission_id, c.Role_id });
                entity.Property(x => x.Permission_id)
                    .HasColumnName("permission_id");
                entity.Property(x => x.Role_id)
                    .HasColumnName("role_id");
            });
        }
    }
}
