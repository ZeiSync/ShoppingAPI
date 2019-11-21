using Microsoft.EntityFrameworkCore.Migrations;

namespace shoppingAPI.Migrations
{
    public partial class fixv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Specifications_SpecificationId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SpecificationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SpecificationId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Specifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.DropIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Specifications");

            migrationBuilder.AddColumn<int>(
                name: "SpecificationId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecificationId",
                table: "Products",
                column: "SpecificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Specifications_SpecificationId",
                table: "Products",
                column: "SpecificationId",
                principalTable: "Specifications",
                principalColumn: "SpecificationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}