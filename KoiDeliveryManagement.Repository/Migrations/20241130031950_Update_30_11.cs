using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoiDeliveryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_30_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RefundDate",
                table: "Transactions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3181), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3181), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3193), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3337), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3337), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3341), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3341), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3347), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3347), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3058), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3058), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3072), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3090), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3090), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 0, 0, 0, 0)), new Guid("8917f89d-0925-4703-bb28-7dfe72807e6a") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3272), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3272), new TimeSpan(0, 0, 0, 0, 0)), new Guid("44814f34-c1a0-44c0-95ac-7f9212e92ae3") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0)), new Guid("0bf084e8-624b-4107-87f9-2cd2dfe2d59f") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3284), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3284), new TimeSpan(0, 0, 0, 0, 0)), new Guid("dfce416a-a25a-4246-9b42-7d51b99cc009") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3289), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3289), new TimeSpan(0, 0, 0, 0, 0)), new Guid("22fae836-40c7-4231-92c4-e758856d2da7") });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3133), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3133), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3137), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3144), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3144), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "RefundDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3381), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3381), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "RefundDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "RefundDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "RefundDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "RefundDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2552), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2552), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 30, 3, 19, 48, 916, DateTimeKind.Unspecified).AddTicks(2590), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefundDate",
                table: "Transactions");

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
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2093), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 28, 1, 30, 51, 833, DateTimeKind.Unspecified).AddTicks(2103), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
