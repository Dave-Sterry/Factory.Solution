using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class date3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Machines",
                newName: "InstallDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Engineers",
                newName: "HireDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InstallDate",
                table: "Machines",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "Engineers",
                newName: "StartDate");
        }
    }
}
