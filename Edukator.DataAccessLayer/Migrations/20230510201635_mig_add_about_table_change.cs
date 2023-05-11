using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class mig_add_about_table_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Abouts",
                newName: "Description2");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Description2",
                table: "Abouts",
                newName: "Description");
        }
    }
}
