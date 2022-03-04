using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GRIDevelopment.Migrations
{
    public partial class creatingfirsttwotables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_products_AttributeIdFK",
                table: "products",
                column: "AttributeIdFK");

            migrationBuilder.AddForeignKey(
                name: "FK_products_product_attributes_AttributeIdFK",
                table: "products",
                column: "AttributeIdFK",
                principalTable: "product_attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_product_attributes_AttributeIdFK",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_AttributeIdFK",
                table: "products");
        }
    }
}
