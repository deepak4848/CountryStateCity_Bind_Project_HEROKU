using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CountryStateCity_Bind_Project.Migrations
{
    public partial class c1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CName",
                table: "tblCitys",
                newName: "DName");

            migrationBuilder.RenameColumn(
                name: "CId",
                table: "tblCitys",
                newName: "DId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DName",
                table: "tblCitys",
                newName: "CName");

            migrationBuilder.RenameColumn(
                name: "DId",
                table: "tblCitys",
                newName: "CId");
        }
    }
}
