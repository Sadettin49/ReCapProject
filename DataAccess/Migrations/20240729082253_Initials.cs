using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Colors",
                newName: "ColorName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Brands",
                newName: "BrandName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ColorName",
                table: "Colors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BrandName",
                table: "Brands",
                newName: "Name");
        }
    }
}
