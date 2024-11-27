using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KoiDeliveryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_27_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Email", "LastUpdateTime", "LastUpdatedBy", "Name", "OwnerId", "Status", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "123 Ocean Drive, Blue City", "555123456", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)), null, null, "contact@aquaticwonders.com", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7631), new TimeSpan(0, 0, 0, 0, 0)), null, "Aquatic Wonders", 2, 1, "https://www.aquaticwonders.com" },
                    { 2, "789 Reef Road, Coral Town", "555987654", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), null, null, "info@marinesupplies.com", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), null, "Marine Supplies Co.", 2, 1, "https://www.marinesupplies.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Email", "FullName", "IsEmailVerified", "LastUpdateTime", "LastUpdatedBy", "PasswordHash", "PhoneNumber", "ProfileImageUrl", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)), null, null, "customer1@example.com", "Customer One", true, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)), null, "12345678", "123456789", null, "Customer", 1, "customer1" },
                    { 2, null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)), null, null, "supplier1@example.com", "Supplier One", true, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0)), null, "12345678", "123456789", null, "Supplier", 1, "supplier1" },
                    { 3, null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)), null, null, "staff1@example.com", "System Staff One", true, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 0, 0, 0, 0)), null, "12345678", "987654321", null, "SystemStaff", 1, "staff1" },
                    { 4, null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)), null, null, "delivery1@example.com", "Delivery Staff One", true, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0)), null, "12345678", "567890123", null, "Delivery", 1, "delivery1" },
                    { 5, null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)), null, null, "admin1@example.com", "Admin One", true, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)), null, "12345678", "456789012", null, "Admin", 1, "admin1" }
                });

            migrationBuilder.InsertData(
                table: "Fishes",
                columns: new[] { "Id", "Breed", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "Dob", "HealthStatus", "ImageUrl", "LastUpdateTime", "LastUpdatedBy", "Name", "Price", "Size", "Status", "SupplierId", "TagNumber", "Weight" },
                values: new object[,]
                {
                    { 1, "Cyprinus rubrofuscus", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), null, null, "A beautiful premium koi fish with red and white patterns.", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", "https://example.com/images/koi1.jpg", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), null, "Koi Premium", 120f, 25.5f, 1, 1, "KOI12345", 1.2f },
                    { 2, "Carassius auratus", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)), null, null, "A golden-colored fancy fish, perfect for aquariums.", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", "https://example.com/images/golden1.jpg", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 0, 0, 0, 0)), null, "Golden Fancy", 90f, 18f, 1, 1, "GOLD56789", 0.8f },
                    { 3, "Arowana", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 0, 0, 0, 0)), null, null, "A rare black dragonfish with elegant movements.", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excellent", "https://example.com/images/dragon1.jpg", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7669), new TimeSpan(0, 0, 0, 0, 0)), null, "Black Dragon", 300f, 35f, 1, 2, "DRAGON89012", 2.5f },
                    { 4, "Silver Carp", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)), null, null, "A silver-scaled fish with shimmering beauty.", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", "https://example.com/images/silver1.jpg", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)), null, "Silver Stream", 80f, 20f, 1, 2, "SILVER34567", 1.5f },
                    { 5, "Rainbowfish", null, new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 0, 0, 0, 0)), null, null, "A vibrant fish with a mix of rainbow colors.", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good", "https://example.com/images/rainbow1.jpg", new DateTimeOffset(new DateTime(2024, 11, 27, 0, 48, 56, 551, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 0, 0, 0, 0)), null, "Rainbow Delight", 110f, 15f, 1, 1, "RAINBOW12345", 0.7f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
