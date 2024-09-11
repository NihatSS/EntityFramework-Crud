using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsoleApp.Migrations
{
    public partial class DeletedPopulationColumnCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Population",
                table: "Countries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
