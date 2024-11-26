using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiDeliveryManagement.Repository.Model;

namespace KoiDeliveryManagement.Repository
{
    public class KoiContext : DbContext
    {
        public KoiContext() { }
        public KoiContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:DefaultConnection"];
            return strConn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(GetConnectionString());

        public DbSet<Order> Orders { get; set; }
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and keys
            modelBuilder.Entity<Certificate>()
                .HasOne(c => c.Fish)
                .WithOne(f => f.Certificate)
                .HasForeignKey<Certificate>(c => c.FishId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Order)
                .WithOne(o => o.Delivery)
                .HasForeignKey<Delivery>(d => d.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.DeliveryStaff)
                .WithMany(u => u.Delivery)
                .HasForeignKey(d => d.DeliveryStaffId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Service)
                .WithMany()
                .HasForeignKey(o => o.ServiceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Fish)
                .WithMany()
                .HasForeignKey(o => o.FishId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Order)
                .WithMany()
                .HasForeignKey(t => t.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Fish>()
                .HasOne(f => f.Supplier)
                .WithMany(s => s.Fishes)
                .HasForeignKey(f => f.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Certificate>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Delivery>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Order>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Service>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Supplier>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Transaction>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Fish>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        }
    }
}
