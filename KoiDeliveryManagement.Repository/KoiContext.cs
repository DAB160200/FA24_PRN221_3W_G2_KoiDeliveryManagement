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
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:DefaultConnection"];
            return strConn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(GetConnectionString());

        #region Entities
        public DbSet<Order> Orders { get; set; }
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Configure Relationships
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

            modelBuilder.Entity<Supplier>()
                .HasOne(s => s.Owner)
                .WithOne(u => u.Supplier)
                .HasForeignKey<Supplier>(s => s.OwnerId)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Configure Identity
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
            #endregion

            #region Seed Data User
            modelBuilder.Entity<User>().HasData(
            new User
            {
            Id = 1,
            Username = "customer1",
            FullName = "Customer One",
            Email = "customer1@example.com",
            PhoneNumber = "123456789",
            PasswordHash = "12345678",
            IsEmailVerified = true,
            Role = "Customer"
            },
            new User
            {
                Id = 2,
                Username = "supplier1",
                FullName = "Supplier One",
                Email = "supplier1@example.com",
                PhoneNumber = "123456789",
                PasswordHash = "12345678",
                IsEmailVerified = true,
                Role = "Supplier"
            }
            ,
            new User
            {
            Id = 3,
            Username = "staff1",
            FullName = "System Staff One",
            Email = "staff1@example.com",
            PhoneNumber = "987654321",
            PasswordHash = "12345678",
            IsEmailVerified = true,
            Role = "SystemStaff"
            },
            new User
            {
            Id = 4,
            Username = "delivery1",
            FullName = "Delivery Staff One",
            Email = "delivery1@example.com",
            PhoneNumber = "567890123",
            PasswordHash = "12345678",
            IsEmailVerified = true,
            Role = "Delivery"
            },
            new User
            {
            Id = 5,
            Username = "admin1",
            FullName = "Admin One",
            Email = "admin1@example.com",
            PhoneNumber = "456789012",
            PasswordHash = "12345678",
            IsEmailVerified = true,
            Role = "Admin"
            },
            new User
            {
            Id = 7,
            Username = "supplier2",
            FullName = "Supplier Two",
            Email = "supplier2@example.com",
            PhoneNumber = "789012345",
            PasswordHash = "12345678",
            IsEmailVerified = true,
            Role = "Supplier"
            }
            );
            #endregion

            #region Seed Data Supplier
            modelBuilder.Entity<Supplier>().HasData(
            new Supplier
            {   
            Id = 1,
            Name = "Aquatic Wonders",
            Address = "123 Ocean Drive, Blue City",
            ContactNumber = "555123456",
            Email = "contact@aquaticwonders.com",
            WebsiteUrl = "https://www.aquaticwonders.com",
            OwnerId = 2
            },
            new Supplier
            {
            Id = 2,
            Name = "Marine Supplies Co.",
            Address = "789 Reef Road, Coral Town",
            ContactNumber = "555987654",
            Email = "info@marinesupplies.com",
            WebsiteUrl = "https://www.marinesupplies.com",
            OwnerId = 7
            }
            );
            #endregion

            #region Seed Data Fish
            modelBuilder.Entity<Fish>().HasData(
            new Fish
            {
            Id = 1,
            Name = "Koi Premium",
            Description = "A beautiful premium koi fish with red and white patterns.",
            Breed = "Cyprinus rubrofuscus",
            Size = 25.5f,
            Weight = 1.2f,
            SupplierId = 1, // Ensure Supplier with Id 1 exists
            Dob = new DateTime(2022, 5, 10),
            HealthStatus = "Healthy",
            TagNumber = "KOI12345",
            Price = 120.0f,
            ImageUrl = "https://example.com/images/koi1.jpg"
            },
            new Fish
            {
            Id = 2,
            Name = "Golden Fancy",
            Description = "A golden-colored fancy fish, perfect for aquariums.",
            Breed = "Carassius auratus",
            Size = 18.0f,
            Weight = 0.8f,
            SupplierId = 1,
            Dob = new DateTime(2023, 2, 15),
            HealthStatus = "Healthy",
            TagNumber = "GOLD56789",
            Price = 90.0f,
            ImageUrl = "https://example.com/images/golden1.jpg"
            },
            new Fish
            {
            Id = 3,
            Name = "Black Dragon",
            Description = "A rare black dragonfish with elegant movements.",
            Breed = "Arowana",
            Size = 35.0f,
            Weight = 2.5f,
            SupplierId = 2, // Ensure Supplier with Id 2 exists
            Dob = new DateTime(2021, 8, 20),
            HealthStatus = "Excellent",
            TagNumber = "DRAGON89012",
            Price = 300.0f,
            ImageUrl = "https://example.com/images/dragon1.jpg"
            },
            new Fish
            {
            Id = 4,
            Name = "Silver Stream",
            Description = "A silver-scaled fish with shimmering beauty.",
            Breed = "Silver Carp",
            Size = 20.0f,
            Weight = 1.5f,
            SupplierId = 2,
            Dob = new DateTime(2023, 1, 1),
            HealthStatus = "Healthy",
            TagNumber = "SILVER34567",
            Price = 80.0f,
            ImageUrl = "https://example.com/images/silver1.jpg"
            },
            new Fish
            {
            Id = 5,
            Name = "Rainbow Delight",
            Description = "A vibrant fish with a mix of rainbow colors.",
            Breed = "Rainbowfish",
            Size = 15.0f,
            Weight = 0.7f,
            SupplierId = 1,
            Dob = new DateTime(2022, 11, 25),
            HealthStatus = "Good",
            TagNumber = "RAINBOW12345",
            Price = 110.0f,
            ImageUrl = "https://example.com/images/rainbow1.jpg"
            }
            );
            #endregion

            #region Seed Data Service
            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    Name = "Health Check",
                    Description = "Comprehensive health check for your koi fish to ensure optimal health.",
                    Price = 50.0f,
                    Category = "Health Check",
                    IsActive = true,
                    ServiceCode = "HC1001",
                    DurationInHours = 2.0f,
                    ImageUrl = "https://example.com/images/healthcheck.jpg",
                    TermsAndConditions = "Includes health assessment and basic treatment.",
                    Rating = 4.5f,
                    IsFeatured = true,
                    Availability = "Weekdays",
                    DiscountPercentage = 10.0f
                },
                new Service
                {
                    Id = 2,
                    Name = "Tank Maintenance",
                    Description = "Regular maintenance service to keep your fish tank clean and healthy.",
                    Price = 75.0f,
                    Category = "Maintenance",
                    IsActive = true,
                    ServiceCode = "MT2002",
                    DurationInHours = 3.0f,
                    ImageUrl = "https://example.com/images/tankmaintenance.jpg",
                    TermsAndConditions = "Includes water cleaning, filter replacement, and plant care.",
                    Rating = 4.7f,
                    IsFeatured = false,
                    Availability = "Weekdays",
                    DiscountPercentage = null
                },
                new Service
                {
                    Id = 3,
                    Name = "Feeding Service",
                    Description = "Scheduled feeding service to ensure your fish are well-fed.",
                    Price = 30.0f,
                    Category = "Feeding",
                    IsActive = true,
                    ServiceCode = "FD3003",
                    DurationInHours = 1.0f,
                    ImageUrl = "https://example.com/images/feedingservice.jpg",
                    TermsAndConditions = "Includes feeding and minor tank observations.",
                    Rating = 4.3f,
                    IsFeatured = false,
                    Availability = "Daily",
                    DiscountPercentage = 5.0f
                },
                new Service
                {
                    Id = 4,
                    Name = "Disease Treatment",
                    Description = "Specialized treatment services for sick or injured koi fish.",
                    Price = 150.0f,
                    Category = "Health Check",
                    IsActive = true,
                    ServiceCode = "DT4004",
                    DurationInHours = 4.0f,
                    ImageUrl = "https://example.com/images/diseasetreatment.jpg",
                    TermsAndConditions = "Includes diagnosis and medication.",
                    Rating = 4.8f,
                    IsFeatured = true,
                    Availability = "Weekends",
                    DiscountPercentage = 15.0f
                },
                new Service
                {
                    Id = 5,
                    Name = "Aquarium Setup",
                    Description = "Professional setup of a new aquarium tailored to your needs.",
                    Price = 200.0f,
                    Category = "Setup",
                    IsActive = true,
                    ServiceCode = "AS5005",
                    DurationInHours = 5.0f,
                    ImageUrl = "https://example.com/images/aquariumsetup.jpg",
                    TermsAndConditions = "Includes installation and initial maintenance.",
                    Rating = 4.9f,
                    IsFeatured = true,
                    Availability = "Weekdays",
                    DiscountPercentage = 20.0f
                }
            );
            #endregion

            #region Seed Data Certificate
            modelBuilder.Entity<Certificate>().HasData(
        new Certificate
        {
            Id = 1,
            FishId = 1, // Link to the first fish
            Name = "Health Certificate",
            Url = "https://example.com/certificates/health1.pdf",
            IssueBy = "Veterinary Authority",
            IssueDate = new DateTime(2023, 5, 20),
            CertificateType = "Health",
            ExpirationDate = new DateTime(2025, 5, 20),
            Description = "A certificate verifying the health of the fish.",
            AuthorityName = "Fish Health Organization",
            AuthorityUrl = "https://fho.example.com",
            AuthorityAddress = "123 Aqua St, Marine City",
            AuthorityContact = "123-456-7890"
        },
        new Certificate
        {
            Id = 2,
            FishId = 2, // Link to the second fish
            Name = "Genetic Certificate",
            Url = "https://example.com/certificates/genetic2.pdf",
            IssueBy = "Genetics Lab Inc.",
            IssueDate = new DateTime(2023, 6, 15),
            CertificateType = "Genetic",
            ExpirationDate = null, // No expiration for genetic certificates
            Description = "Certificate verifying the genetic purity of the fish.",
            AuthorityName = "Koi Genetics Authority",
            AuthorityUrl = "https://kga.example.com",
            AuthorityAddress = "456 River Lane, Aqua Town",
            AuthorityContact = "987-654-3210"
        },
        new Certificate
        {
            Id = 3,
            FishId = 3, // Link to the third fish
            Name = "Origin Certificate",
            Url = "https://example.com/certificates/origin3.pdf",
            IssueBy = "Fish Breeder Association",
            IssueDate = new DateTime(2022, 9, 10),
            CertificateType = "Origin",
            ExpirationDate = new DateTime(2030, 9, 10),
            Description = "Certificate verifying the origin and lineage of the fish.",
            AuthorityName = "International Breeder Council",
            AuthorityUrl = "https://ibc.example.com",
            AuthorityAddress = "789 Coral Reef Rd, Ocean City",
            AuthorityContact = "456-789-1234"
        }
        );
            #endregion

            #region Seed Data Order
            modelBuilder.Entity<Order>().HasData(
        new Order
        {
            Id = 1,
            CustomerId = 1,
            ServiceId = 1,
            FishId = 1,
            OrderDate = new DateTime(2024, 11, 15),
            DeliveryDate = new DateTime(2024, 11, 20),
            Rating = 5,
            Feedback = "Amazing service! Everything was perfect.",
            Total = 15000,
            IssueReported = null,
            PaymentReferenceId = "PAY12345",
            IsGift = false,
            UniqueTrackingId = Guid.NewGuid()
        },
        new Order
        {
            Id = 2,
            CustomerId = 1,
            ServiceId = 2,
            FishId = 2,
            OrderDate = new DateTime(2024, 11, 16),
            DeliveryDate = new DateTime(2024, 11, 21),
            Rating = 4,
            Feedback = "Good service, but delivery was slightly delayed.",
            Total = 18000,
            IssueReported = "Late delivery by 2 hours.",
            PaymentReferenceId = "PAY67890",
            IsGift = true,
            UniqueTrackingId = Guid.NewGuid()
        },
        new Order
        {
            Id = 3,
            CustomerId = 1,
            ServiceId = 3,
            FishId = 3,
            OrderDate = new DateTime(2024, 11, 17),
            DeliveryDate = new DateTime(2024, 11, 22),
            Rating = 3,
            Feedback = "Fish was healthy but packaging was subpar.",
            Total = 12000,
            IssueReported = "Damaged packaging.",
            PaymentReferenceId = "PAY11223",
            IsGift = false,
            UniqueTrackingId = Guid.NewGuid()
        },
        new Order
        {
            Id = 4,
            CustomerId = 1,
            ServiceId = 4,
            FishId = 4,
            OrderDate = new DateTime(2024, 11, 18),
            DeliveryDate = new DateTime(2024, 11, 23),
            Rating = null, // Customer hasn't rated yet
            Feedback = null,
            Total = 22000,
            IssueReported = null,
            PaymentReferenceId = "PAY44556",
            IsGift = true,
            UniqueTrackingId = Guid.NewGuid()
        },
        new Order
        {
            Id = 5,
            CustomerId = 1,
            ServiceId = 5,
            FishId = 5,
            OrderDate = new DateTime(2024, 11, 19),
            DeliveryDate = new DateTime(2024, 11, 24),
            Rating = 5,
            Feedback = "Fantastic experience! Highly recommend.",
            Total = 30000,
            IssueReported = null,
            PaymentReferenceId = "PAY77889",
            IsGift = false,
            UniqueTrackingId = Guid.NewGuid()
        });
            #endregion

            #region Seed Data Delivery
            modelBuilder.Entity<Delivery>().HasData(
        new Delivery
        {
            Id = 1,
            OrderId = 1,
            DeliveryStaffId = 4,
            Location = "123 Fish Street, Koi City",
            EstimatedArrivalDate = new DateTime(2024, 11, 20, 14, 0, 0),
            Description = "Delivering a healthy koi fish to the customer.",
            DeliveryMethod = "Standard Delivery",
            TrackingCode = "DEL12345",
            PackageType = "Standard Box",
            Feedback = "Customer confirmed fish was in good condition upon delivery.",
            Rating = 5
        },
        new Delivery
        {
            Id = 2,
            OrderId = 2,
            DeliveryStaffId = 4,
            Location = "456 Water Lane, Koi City",
            EstimatedArrivalDate = new DateTime(2024, 11, 21, 15, 30, 0),
            Description = "Delivering koi fish and maintenance service.",
            DeliveryMethod = "Express Delivery",
            TrackingCode = "DEL67890",
            PackageType = "Insulated Box",
            Feedback = "Customer happy with the fast delivery.",
            Rating = 4
        },
        new Delivery
        {
            Id = 3,
            OrderId = 3,
            DeliveryStaffId = 4,
            Location = "789 Pond Avenue, Koi City",
            EstimatedArrivalDate = new DateTime(2024, 11, 22, 10, 0, 0),
            Description = "Delivering koi fish with an issue in packaging.",
            DeliveryMethod = "Standard Delivery",
            TrackingCode = "DEL11223",
            PackageType = "Standard Box",
            Feedback = "Customer reported packaging damage, but fish was unharmed.",
            Rating = 3
        },
        new Delivery
        {
            Id = 4,
            OrderId = 4,
            DeliveryStaffId = 4,
            Location = "101 Fish Lane, Koi City",
            EstimatedArrivalDate = new DateTime(2024, 11, 23, 16, 30, 0),
            Description = "Delivering koi fish as a gift.",
            DeliveryMethod = "Gift Wrap Delivery",
            TrackingCode = "DEL44556",
            PackageType = "Gift Box",
            Feedback = "Customer excited for the gift delivery.",
            Rating = null // Rating not yet given
        },
        new Delivery
        {
            Id = 5,
            OrderId = 5,
            DeliveryStaffId = 4,
            Location = "202 Coral Road, Koi City",
            EstimatedArrivalDate = new DateTime(2024, 11, 24, 11, 0, 0),
            Description = "Delivering a healthy koi fish with premium service.",
            DeliveryMethod = "Premium Delivery",
            TrackingCode = "DEL77889",
            PackageType = "Premium Box",
            Feedback = "Customer highly satisfied with the delivery and fish condition.",
            Rating = 5
        });
            #endregion

            #region Seed Data Transaction
            modelBuilder.Entity<Transaction>().HasData(
        new Transaction
        {
            Id = 1,
            OrderId = 1,
            TransactionDate = new DateTime(2024, 11, 20, 14, 30, 0),
            Amount = 150.0f,
            PaymentMethod = "Credit Card",
            PaymentId = "PAY12345",
            Notes = "Payment for koi fish and delivery.",
            IsSuccessful = true,
            TransactionStatus = "Completed",
            Currency = "USD",
            TransactionFee = 2.5f, // 2.5% fee
            RefundAmount = null
        },
        new Transaction
        {
            Id = 2,
            OrderId = 2,
            TransactionDate = new DateTime(2024, 11, 21, 16, 0, 0),
            Amount = 200.0f,
            PaymentMethod = "PayPal",
            PaymentId = "PAY67890",
            Notes = "Payment for koi fish and service.",
            IsSuccessful = true,
            TransactionStatus = "Completed",
            Currency = "USD",
            TransactionFee = 3.0f, // 3% fee
            RefundAmount = null
        },
        new Transaction
        {
            Id = 3,
            OrderId = 3,
            TransactionDate = new DateTime(2024, 11, 22, 11, 30, 0),
            Amount = 180.0f,
            PaymentMethod = "Credit Card",
            PaymentId = "PAY11223",
            Notes = "Payment for koi fish with packaging issue.",
            IsSuccessful = false,
            TransactionStatus = "Failed",
            Currency = "USD",
            TransactionFee = 2.5f,
            RefundAmount = 180.0f // Full refund due to failed transaction
        },
        new Transaction
        {
            Id = 4,
            OrderId = 4,
            TransactionDate = new DateTime(2024, 11, 23, 17, 0, 0),
            Amount = 250.0f,
            PaymentMethod = "Bank Transfer",
            PaymentId = "PAY44556",
            Notes = "Payment for koi fish gift delivery.",
            IsSuccessful = true,
            TransactionStatus = "Completed",
            Currency = "USD",
            TransactionFee = 1.5f, // 1.5% fee
            RefundAmount = null
        },
        new Transaction
        {
            Id = 5,
            OrderId = 5,
            TransactionDate = new DateTime(2024, 11, 24, 12, 30, 0),
            Amount = 300.0f,
            PaymentMethod = "Credit Card",
            PaymentId = "PAY77889",
            Notes = "Payment for koi fish and premium service.",
            IsSuccessful = true,
            TransactionStatus = "Completed",
            Currency = "USD",
            TransactionFee = 2.0f, // 2% fee
            RefundAmount = null
        }
    );
            #endregion
        }
    }
}
