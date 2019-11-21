using Microsoft.EntityFrameworkCore.Migrations;

namespace shoppingAPI.Migrations
{
    public partial class fixProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantities",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantities",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }
    }
}