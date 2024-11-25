using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_25_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Users_OwnerId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_OwnerId",
                table: "Suppliers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_OwnerId",
                table: "Suppliers",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Users_OwnerId",
                table: "Suppliers",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
