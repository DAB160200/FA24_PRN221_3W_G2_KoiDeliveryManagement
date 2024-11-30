using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoiDeliveryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_28_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2469), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2469), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2472), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2472), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2578), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2386), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2386), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2393), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2396), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2401), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2401), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 0, 0, 0, 0)), new Guid("b5faf2cd-212c-46f7-a1e0-adefe5592d06") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 0, 0, 0, 0)), new Guid("6974e7d6-e2ac-420e-90be-86ba2f718494") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 0, 0, 0, 0)), new Guid("4cc3fdbc-c1b7-4f0e-a292-b6026e87a00e") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2544), new TimeSpan(0, 0, 0, 0, 0)), new Guid("5af795a1-bc35-41f6-8ec9-e27167f40561") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, 0, 0, 0, 0)), new Guid("29bcca8a-2564-4680-a9ae-0b83089c23ce") });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2424), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2358), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2358), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2364), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2364), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2620), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2620), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CreatedTime", "Dob", "Gender", "LastUpdateTime" },
                values: new object[] { "123 Main Street, City", new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreatedTime", "Dob", "Gender", "LastUpdateTime" },
                values: new object[] { "123 Main Street, City", new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CreatedTime", "Dob", "Gender", "LastUpdateTime" },
                values: new object[] { "123 Main Street, City", new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "CreatedTime", "Dob", "Gender", "LastUpdateTime" },
                values: new object[] { "123 Main Street, City", new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "CreatedTime", "Dob", "Gender", "LastUpdateTime" },
                values: new object[] { "123 Main Street, City", new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "CreatedTime", "Dob", "Gender", "LastUpdateTime" },
                values: new object[] { "123 Main Street, City", new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6141), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6156), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6156), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6161), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6161), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5733), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5733), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5739), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5739), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6024), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6024), new TimeSpan(0, 0, 0, 0, 0)), new Guid("b7fadbe6-5ebe-4ece-8067-8f3f35c1bdb7") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6039), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6039), new TimeSpan(0, 0, 0, 0, 0)), new Guid("dcd017be-3e7b-4846-b9cf-ba71cd318e6e") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6047), new TimeSpan(0, 0, 0, 0, 0)), new Guid("803e614d-ad47-4fd7-bc4c-27265a43a818") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 0, 0, 0, 0)), new Guid("f3c796af-ea32-4dc4-9323-dcebf0e1e3ff") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 0, 0, 0, 0)), new Guid("5a4b21f1-3406-4aa3-9c55-b0e1f0112548") });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5843), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5843), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5853), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5853), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6222), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6236), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6236), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6246), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6246), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4897), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4903), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4909), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4909), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4912), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(4912), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
