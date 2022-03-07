using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GRIDevelopment.Migrations
{
    public partial class _2ndcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Type",
                table: "products",
                newName: "Tire_Size");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "products",
                newName: "Rim_Size");

            migrationBuilder.RenameColumn(
                name: "Measure_Unit",
                table: "products",
                newName: "Pattern");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "products",
                newName: "Application");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tire_Size",
                table: "products",
                newName: "Product_Type");

            migrationBuilder.RenameColumn(
                name: "Rim_Size",
                table: "products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Pattern",
                table: "products",
                newName: "Measure_Unit");

            migrationBuilder.RenameColumn(
                name: "Application",
                table: "products",
                newName: "Brand");
        }
    }
}
