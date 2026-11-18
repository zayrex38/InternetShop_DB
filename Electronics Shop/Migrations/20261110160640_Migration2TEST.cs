using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Electronics_Shop.Migrations
{
    /// <inheritdoc />
    public partial class Migration2TEST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Test",
                table: "ProductsTable",
                newName: "Test2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Test2",
                table: "ProductsTable",
                newName: "Test");
        }
    }
}
