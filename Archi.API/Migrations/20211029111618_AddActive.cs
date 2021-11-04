using Microsoft.EntityFrameworkCore.Migrations;

namespace Archi.API.Migrations
{
    public partial class AddActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Pizzas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Pizzas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Topping",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Topping",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Customers");
        }
    }
}
