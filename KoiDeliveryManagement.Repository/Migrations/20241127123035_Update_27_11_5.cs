using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoiDeliveryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_27_11_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Suppliers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaxNumber",
                table: "Suppliers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxCode",
                table: "Suppliers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

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
                columns: new[] { "CreatedTime", "Description", "FaxNumber", "LastUpdateTime", "TaxCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5631), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description", "FaxNumber", "LastUpdateTime", "TaxCode" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)), null, null, new DateTimeOffset(new DateTime(2024, 11, 27, 12, 30, 34, 592, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "FaxNumber",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "TaxCode",
                table: "Suppliers");

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(679), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(679), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(681), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(503), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(503), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)), new Guid("4d4448a2-f401-4e6f-b925-6bc8a6e884c1") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(625), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(625), new TimeSpan(0, 0, 0, 0, 0)), new Guid("eac8a99c-3dc8-4a05-8730-182e4b5734ea") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(629), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(629), new TimeSpan(0, 0, 0, 0, 0)), new Guid("300245ff-4a63-481e-a3b6-b27d6ce2110d") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 0, 0, 0, 0)), new Guid("4b3c6598-a552-4c11-9c29-75a002877d02") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 0, 0, 0, 0)), new Guid("91522712-d29e-47e8-833c-2254c68add80") });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(528), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(528), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(538), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(538), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(543), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(543), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(467), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(467), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(703), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(703), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(711), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(711), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(713), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(713), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(716), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(716), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(718), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(718), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(267), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(267), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 54, 49, 282, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
