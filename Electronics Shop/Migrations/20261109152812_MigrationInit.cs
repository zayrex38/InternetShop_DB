using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Electronics_Shop.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CouriersTable",
                columns: table => new
                {
                    courier_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    middle_name = table.Column<string>(type: "TEXT", nullable: false),
                    contact = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouriersTable", x => x.courier_id);
                });

            migrationBuilder.CreateTable(
                name: "CustomersTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    middle_name = table.Column<string>(type: "TEXT", nullable: false),
                    birth_date = table.Column<string>(type: "TEXT", nullable: false),
                    address = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    login = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                    manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    price = table.Column<decimal>(type: "TEXT", nullable: false),
                    specifications = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrdersTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    courier_id = table.Column<int>(type: "INTEGER", nullable: false),
                    delivery_adrress = table.Column<string>(type: "TEXT", nullable: false),
                    desired_date = table.Column<string>(type: "TEXT", nullable: false),
                    order_date = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersTable", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrdersTable_CouriersTable_courier_id",
                        column: x => x.courier_id,
                        principalTable: "CouriersTable",
                        principalColumn: "courier_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersTable_CustomersTable_customer_id",
                        column: x => x.customer_id,
                        principalTable: "CustomersTable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sold_ProductsTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    order_id = table.Column<int>(type: "INTEGER", nullable: false),
                    product_id = table.Column<int>(type: "INTEGER", nullable: false),
                    quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    sold_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    sale_data = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sold_ProductsTable", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sold_ProductsTable_OrdersTable_order_id",
                        column: x => x.order_id,
                        principalTable: "OrdersTable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sold_ProductsTable_ProductsTable_product_id",
                        column: x => x.product_id,
                        principalTable: "ProductsTable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersTable_courier_id",
                table: "OrdersTable",
                column: "courier_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersTable_customer_id",
                table: "OrdersTable",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sold_ProductsTable_order_id",
                table: "Sold_ProductsTable",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Sold_ProductsTable_product_id",
                table: "Sold_ProductsTable",
                column: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sold_ProductsTable");

            migrationBuilder.DropTable(
                name: "OrdersTable");

            migrationBuilder.DropTable(
                name: "ProductsTable");

            migrationBuilder.DropTable(
                name: "CouriersTable");

            migrationBuilder.DropTable(
                name: "CustomersTable");
        }
    }
}
