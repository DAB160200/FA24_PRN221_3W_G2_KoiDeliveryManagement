﻿// <auto-generated />
using System;
using KoiDeliveryManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KoiDeliveryManagement.Repository.Migrations
{
    [DbContext(typeof(KoiContext))]
    [Migration("20241127004857_Update_27_11")]
    partial class Update_27_11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorityAddress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AuthorityContact")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("AuthorityName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AuthorityUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificateType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FishId")
                        .HasColumnType("int");

                    b.Property<string>("IssueBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FishId")
                        .IsUnique();

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeliveryMethod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DeliveryStaffId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("EstimatedArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Feedback")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PackageType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TrackingCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryStaffId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Fish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("HealthStatus")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float?>("Price")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<float>("Size")
                        .HasColumnType("real");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("TagNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Fishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Breed = "Cyprinus rubrofuscus",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "A beautiful premium koi fish with red and white patterns.",
                            Dob = new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HealthStatus = "Healthy",
                            ImageUrl = "https://example.com/images/koi1.jpg",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Koi Premium",
                            Price = 120f,
                            Size = 25.5f,
                            Status = 1,
                            SupplierId = 1,
                            TagNumber = "KOI12345",
                            Weight = 1.2f
                        },
                        new
                        {
                            Id = 2,
                            Breed = "Carassius auratus",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "A golden-colored fancy fish, perfect for aquariums.",
                            Dob = new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HealthStatus = "Healthy",
                            ImageUrl = "https://example.com/images/golden1.jpg",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Golden Fancy",
                            Price = 90f,
                            Size = 18f,
                            Status = 1,
                            SupplierId = 1,
                            TagNumber = "GOLD56789",
                            Weight = 0.8f
                        },
                        new
                        {
                            Id = 3,
                            Breed = "Arowana",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "A rare black dragonfish with elegant movements.",
                            Dob = new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HealthStatus = "Excellent",
                            ImageUrl = "https://example.com/images/dragon1.jpg",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Black Dragon",
                            Price = 300f,
                            Size = 35f,
                            Status = 1,
                            SupplierId = 2,
                            TagNumber = "DRAGON89012",
                            Weight = 2.5f
                        },
                        new
                        {
                            Id = 4,
                            Breed = "Silver Carp",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "A silver-scaled fish with shimmering beauty.",
                            Dob = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HealthStatus = "Healthy",
                            ImageUrl = "https://example.com/images/silver1.jpg",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Silver Stream",
                            Price = 80f,
                            Size = 20f,
                            Status = 1,
                            SupplierId = 2,
                            TagNumber = "SILVER34567",
                            Weight = 1.5f
                        },
                        new
                        {
                            Id = 5,
                            Breed = "Rainbowfish",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "A vibrant fish with a mix of rainbow colors.",
                            Dob = new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HealthStatus = "Good",
                            ImageUrl = "https://example.com/images/rainbow1.jpg",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Rainbow Delight",
                            Price = 110f,
                            Size = 15f,
                            Status = 1,
                            SupplierId = 1,
                            TagNumber = "RAINBOW12345",
                            Weight = 0.7f
                        });
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Feedback")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("FishId")
                        .HasColumnType("int");

                    b.Property<string>("IssueReported")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FishId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Ocean Drive, Blue City",
                            ContactNumber = "555123456",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "contact@aquaticwonders.com",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Aquatic Wonders",
                            OwnerId = 2,
                            Status = 1,
                            WebsiteUrl = "https://www.aquaticwonders.com"
                        },
                        new
                        {
                            Id = 2,
                            Address = "789 Reef Road, Coral Town",
                            ContactNumber = "555987654",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "info@marinesupplies.com",
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Marine Supplies Co.",
                            OwnerId = 2,
                            Status = 1,
                            WebsiteUrl = "https://www.marinesupplies.com"
                        });
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsSuccessful")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ProfileImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Role")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "customer1@example.com",
                            FullName = "Customer One",
                            IsEmailVerified = true,
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)),
                            PasswordHash = "12345678",
                            PhoneNumber = "123456789",
                            Role = "Customer",
                            Status = 1,
                            Username = "customer1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "supplier1@example.com",
                            FullName = "Supplier One",
                            IsEmailVerified = true,
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)),
                            PasswordHash = "12345678",
                            PhoneNumber = "123456789",
                            Role = "Supplier",
                            Status = 1,
                            Username = "supplier1"
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "staff1@example.com",
                            FullName = "System Staff One",
                            IsEmailVerified = true,
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)),
                            PasswordHash = "12345678",
                            PhoneNumber = "987654321",
                            Role = "SystemStaff",
                            Status = 1,
                            Username = "staff1"
                        },
                        new
                        {
                            Id = 4,
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "delivery1@example.com",
                            FullName = "Delivery Staff One",
                            IsEmailVerified = true,
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)),
                            PasswordHash = "12345678",
                            PhoneNumber = "567890123",
                            Role = "Delivery",
                            Status = 1,
                            Username = "delivery1"
                        },
                        new
                        {
                            Id = 5,
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "admin1@example.com",
                            FullName = "Admin One",
                            IsEmailVerified = true,
                            LastUpdateTime = new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)),
                            PasswordHash = "12345678",
                            PhoneNumber = "456789012",
                            Role = "Admin",
                            Status = 1,
                            Username = "admin1"
                        });
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Certificate", b =>
                {
                    b.HasOne("KoiDeliveryManagement.Repository.Model.Fish", "Fish")
                        .WithOne("Certificate")
                        .HasForeignKey("KoiDeliveryManagement.Repository.Model.Certificate", "FishId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Fish");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Delivery", b =>
                {
                    b.HasOne("KoiDeliveryManagement.Repository.Model.User", "DeliveryStaff")
                        .WithMany("Delivery")
                        .HasForeignKey("DeliveryStaffId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("KoiDeliveryManagement.Repository.Model.Order", "Order")
                        .WithOne("Delivery")
                        .HasForeignKey("KoiDeliveryManagement.Repository.Model.Delivery", "OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DeliveryStaff");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Fish", b =>
                {
                    b.HasOne("KoiDeliveryManagement.Repository.Model.Supplier", "Supplier")
                        .WithMany("Fishes")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Order", b =>
                {
                    b.HasOne("KoiDeliveryManagement.Repository.Model.User", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("KoiDeliveryManagement.Repository.Model.Fish", "Fish")
                        .WithMany()
                        .HasForeignKey("FishId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("KoiDeliveryManagement.Repository.Model.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Fish");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Transaction", b =>
                {
                    b.HasOne("KoiDeliveryManagement.Repository.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Fish", b =>
                {
                    b.Navigation("Certificate");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Order", b =>
                {
                    b.Navigation("Delivery")
                        .IsRequired();
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.Supplier", b =>
                {
                    b.Navigation("Fishes");
                });

            modelBuilder.Entity("KoiDeliveryManagement.Repository.Model.User", b =>
                {
                    b.Navigation("Delivery");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
