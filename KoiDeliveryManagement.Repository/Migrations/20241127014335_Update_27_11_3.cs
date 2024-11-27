using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KoiDeliveryManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_27_11_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Transactions",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "RefundAmount",
                table: "Transactions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TransactionFee",
                table: "Transactions",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8128), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8128), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8231), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8046), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8046), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8056), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8056), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Fishes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8061), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8061), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 0, 0, 0, 0)), new Guid("8fa5a796-0073-4e23-8608-ade63800cf28") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, 0, 0, 0, 0)), new Guid("6931ec33-70b1-47b4-a579-fdb8b6ad07a3") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 0, 0, 0, 0)), new Guid("3db89b34-ed27-4337-a9e6-9e0356ae43f1") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, 0, 0, 0, 0)), new Guid("05bd3a70-47d5-4eb2-8fa4-034df28ee91b") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), new Guid("e5d87956-2d4d-4b63-8f56-393f61665dca") });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8091), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8091), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8096), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8099), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8099), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8025), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8025), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedTime", "Currency", "DeletedBy", "DeletedTime", "IsSuccessful", "LastUpdateTime", "LastUpdatedBy", "Notes", "OrderId", "PaymentId", "PaymentMethod", "RefundAmount", "Status", "TransactionDate", "TransactionFee", "TransactionStatus" },
                values: new object[,]
                {
                    { 1, 150f, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)), "USD", null, null, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)), null, "Payment for koi fish and delivery.", 1, "PAY12345", "Credit Card", null, 1, new DateTime(2024, 11, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), 2.5f, "Completed" },
                    { 2, 200f, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 0, 0, 0, 0)), "USD", null, null, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 0, 0, 0, 0)), null, "Payment for koi fish and service.", 2, "PAY67890", "PayPal", null, 1, new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Completed" },
                    { 3, 180f, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8271), new TimeSpan(0, 0, 0, 0, 0)), "USD", null, null, false, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8271), new TimeSpan(0, 0, 0, 0, 0)), null, "Payment for koi fish with packaging issue.", 3, "PAY11223", "Credit Card", 180f, 1, new DateTime(2024, 11, 22, 11, 30, 0, 0, DateTimeKind.Unspecified), 2.5f, "Failed" },
                    { 4, 250f, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8274), new TimeSpan(0, 0, 0, 0, 0)), "USD", null, null, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8274), new TimeSpan(0, 0, 0, 0, 0)), null, "Payment for koi fish gift delivery.", 4, "PAY44556", "Bank Transfer", null, 1, new DateTime(2024, 11, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 1.5f, "Completed" },
                    { 5, 300f, null, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8276), new TimeSpan(0, 0, 0, 0, 0)), "USD", null, null, true, new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(8276), new TimeSpan(0, 0, 0, 0, 0)), null, "Payment for koi fish and premium service.", 5, "PAY77889", "Credit Card", null, 1, new DateTime(2024, 11, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), 2f, "Completed" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7867), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7867), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7869), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7869), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7871), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 43, 34, 672, DateTimeKind.Unspecified).AddTicks(7871), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "RefundAmount",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransactionFee",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransactionStatus",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3092), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3092), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 0, 0, 0, 0)) });

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 0, 0, 0, 0)), new Guid("cf73caab-5412-480a-b0d1-7477910ec922") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1ca2a64c-1f4f-4931-b45a-d45a0e1d2e05") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 0, 0, 0, 0)), new Guid("298fcd25-2fda-4d07-a2ea-d9a05b44c72c") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 0, 0, 0, 0)), new Guid("bc546b89-bc9c-477d-8284-eb99a8aff515") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime", "UniqueTrackingId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3229), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3229), new TimeSpan(0, 0, 0, 0, 0)), new Guid("9c5227d0-b2ec-404d-b304-f8f0ec42b39b") });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3044), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "LastUpdateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3054), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 27, 1, 39, 21, 337, DateTimeKind.Unspecified).AddTicks(3054), new TimeSpan(0, 0, 0, 0, 0)) });

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
        }
    }
}
