using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Electronics_Shop.Migrations
{
    /// <inheritdoc />
    public partial class MigrationAddTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Test",
                table: "ProductsTable",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "ProductsTable");
        }
    }
}
