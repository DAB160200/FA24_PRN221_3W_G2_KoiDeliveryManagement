using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KoiDeliveryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_27_11_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Services",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "DiscountPercentage",
                table: "Services",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DurationInHours",
                table: "Services",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Services",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "Services",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceCode",
                table: "Services",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TermsAndConditions",
                table: "Services",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsGift",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PaymentReferenceId",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueTrackingId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "AuthorityAddress", "AuthorityContact", "AuthorityName", "AuthorityUrl", "CertificateType", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "ExpirationDate", "FishId", "IssueBy", "IssueDate", "LastUpdateTime", "LastUpdatedBy", "Name", "Status", "Url" },
                values: new object[,]
                {
                    { 1, "123 Aqua St, Marine City", "123-456-7890", "Fish Health Organization", "https://fho.example.com", "Health", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)), null, null, "A certificate verifying the health of the fish.", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Veterinary Authority", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)), null, "Health Certificate", 1, "https://example.com/certificates/health1.pdf" },
                    { 2, "456 River Lane, Aqua Town", "987-654-3210", "Koi Genetics Authority", "https://kga.example.com", "Genetic", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3092), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Certificate verifying the genetic purity of the fish.", null, 2, "Genetics Lab Inc.", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3092), new TimeSpan(0, 0, 0, 0, 0)), null, "Genetic Certificate", 1, "https://example.com/certificates/genetic2.pdf" },
                    { 3, "789 Coral Reef Rd, Ocean City", "456-789-1234", "International Breeder Council", "https://ibc.example.com", "Origin", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Certificate verifying the origin and lineage of the fish.", new DateTime(2030, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Fish Breeder Association", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)), null, "Origin Certificate", 1, "https://example.com/certificates/origin3.pdf" }
                });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Availability", "Category", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "DiscountPercentage", "DurationInHours", "ImageUrl", "IsActive", "IsFeatured", "LastUpdateTime", "LastUpdatedBy", "Name", "Price", "Rating", "ServiceCode", "Status", "TermsAndConditions" },
                values: new object[,]
                {
                    { 1, "Weekdays", "Health Check", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Comprehensive health check for your koi fish to ensure optimal health.", 10f, 2f, "https://example.com/images/healthcheck.jpg", true, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 0, 0, 0, 0)), null, "Health Check", 50f, 4.5f, "HC1001", 1, "Includes health assessment and basic treatment." },
                    { 2, "Weekdays", "Maintenance", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Regular maintenance service to keep your fish tank clean and healthy.", null, 3f, "https://example.com/images/tankmaintenance.jpg", true, false, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)), null, "Tank Maintenance", 75f, 4.7f, "MT2002", 1, "Includes water cleaning, filter replacement, and plant care." },
                    { 3, "Daily", "Feeding", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Scheduled feeding service to ensure your fish are well-fed.", 5f, 1f, "https://example.com/images/feedingservice.jpg", true, false, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)), null, "Feeding Service", 30f, 4.3f, "FD3003", 1, "Includes feeding and minor tank observations." },
                    { 4, "Weekends", "Health Check", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Specialized treatment services for sick or injured koi fish.", 15f, 4f, "https://example.com/images/diseasetreatment.jpg", true, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), null, "Disease Treatment", 150f, 4.8f, "DT4004", 1, "Includes diagnosis and medication." },
                    { 5, "Weekdays", "Setup", null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3054), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Professional setup of a new aquarium tailored to your needs.", 20f, 5f, "https://example.com/images/aquariumsetup.jpg", true, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3054), new TimeSpan(0, 0, 0, 0, 0)), null, "Aquarium Setup", 200f, 4.9f, "AS5005", 1, "Includes installation and initial maintenance." }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2746), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2746), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2752), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2752), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "CustomerId", "DeletedBy", "DeletedTime", "DeliveryDate", "Feedback", "FishId", "IsGift", "IssueReported", "LastUpdateTime", "LastUpdatedBy", "OrderDate", "PaymentReferenceId", "Rating", "ServiceId", "Status", "Total", "UniqueTrackingId" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazing service! Everything was perfect.", 1, false, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAY12345", 5, 1, 1, 15000f, new Guid("cf73caab-5412-480a-b0d1-7477910ec922") },
                    { 2, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good service, but delivery was slightly delayed.", 2, true, "Late delivery by 2 hours.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAY67890", 4, 2, 1, 18000f, new Guid("1ca2a64c-1f4f-4931-b45a-d45a0e1d2e05") },
                    { 3, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish was healthy but packaging was subpar.", 3, false, "Damaged packaging.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAY11223", 3, 3, 1, 12000f, new Guid("298fcd25-2fda-4d07-a2ea-d9a05b44c72c") },
                    { 4, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, true, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAY44556", null, 4, 1, 22000f, new Guid("bc546b89-bc9c-477d-8284-eb99a8aff515") },
                    { 5, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3229), new TimeSpan(0, 0, 0, 0, 0)), 1, null, null, new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic experience! Highly recommend.", 5, false, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3229), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "PAY77889", 5, 5, 1, 30000f, new Guid("9c5227d0-b2ec-404d-b304-f8f0ec42b39b") }
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "DeliveryMethod", "DeliveryStaffId", "Description", "EstimatedArrivalDate", "Feedback", "LastUpdateTime", "LastUpdatedBy", "Location", "OrderId", "PackageType", "Rating", "Status", "TrackingCode" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Standard Delivery", 4, "Delivering a healthy koi fish to the customer.", new DateTime(2024, 11, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "Customer confirmed fish was in good condition upon delivery.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0)), null, "123 Fish Street, Koi City", 1, "Standard Box", 5, 1, "DEL12345" },
                    { 2, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Express Delivery", 4, "Delivering koi fish and maintenance service.", new DateTime(2024, 11, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), "Customer happy with the fast delivery.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)), null, "456 Water Lane, Koi City", 2, "Insulated Box", 4, 1, "DEL67890" },
                    { 3, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Standard Delivery", 4, "Delivering koi fish with an issue in packaging.", new DateTime(2024, 11, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), "Customer reported packaging damage, but fish was unharmed.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), null, "789 Pond Avenue, Koi City", 3, "Standard Box", 3, 1, "DEL11223" },
                    { 4, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Gift Wrap Delivery", 4, "Delivering koi fish as a gift.", new DateTime(2024, 11, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), "Customer excited for the gift delivery.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 0, 0, 0, 0)), null, "101 Fish Lane, Koi City", 4, "Gift Box", null, 1, "DEL44556" },
                    { 5, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Premium Delivery", 4, "Delivering a healthy koi fish with premium service.", new DateTime(2024, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "Customer highly satisfied with the delivery and fish condition.", new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)), null, "202 Coral Road, Koi City", 5, "Premium Box", 5, 1, "DEL77889" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "DiscountPercentage",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "DurationInHours",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceCode",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "TermsAndConditions",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsGift",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentReferenceId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UniqueTrackingId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
