using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalOrderAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name", "PhoneNumber", "TotalOrderAmount" },
                values: new object[,]
                {
                    { 1, "Customer 1", "555-123-01", 0m },
                    { 2, "Customer 2", "555-123-02", 0m },
                    { 3, "Customer 3", "555-123-03", 0m },
                    { 4, "Customer 4", "555-123-04", 0m },
                    { 5, "Customer 5", "555-123-05", 0m },
                    { 6, "Customer 6", "555-123-06", 0m },
                    { 7, "Customer 7", "555-123-07", 0m },
                    { 8, "Customer 8", "555-123-08", 0m },
                    { 9, "Customer 9", "555-123-09", 0m },
                    { 10, "Customer 10", "555-123-10", 0m },
                    { 11, "Customer 11", "555-123-11", 0m },
                    { 12, "Customer 12", "555-123-12", 0m },
                    { 13, "Customer 13", "555-123-13", 0m },
                    { 14, "Customer 14", "555-123-14", 0m },
                    { 15, "Customer 15", "555-123-15", 0m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderNumber" },
                values: new object[,]
                {
                    { 1, 406m, 1, "Order-1-1" },
                    { 2, 97m, 1, "Order-1-2" },
                    { 3, 436m, 1, "Order-1-3" },
                    { 4, 312m, 1, "Order-1-4" },
                    { 5, 160m, 2, "Order-2-1" },
                    { 6, 224m, 2, "Order-2-2" },
                    { 7, 347m, 2, "Order-2-3" },
                    { 8, 419m, 2, "Order-2-4" },
                    { 9, 280m, 3, "Order-3-1" },
                    { 10, 35m, 3, "Order-3-2" },
                    { 11, 146m, 4, "Order-4-1" },
                    { 12, 307m, 4, "Order-4-2" },
                    { 13, 88m, 4, "Order-4-3" },
                    { 14, 462m, 4, "Order-4-4" },
                    { 15, 128m, 6, "Order-6-1" },
                    { 16, 264m, 7, "Order-7-1" },
                    { 17, 145m, 9, "Order-9-1" },
                    { 18, 159m, 9, "Order-9-2" },
                    { 19, 410m, 9, "Order-9-3" },
                    { 20, 489m, 9, "Order-9-4" },
                    { 21, 33m, 10, "Order-10-1" },
                    { 22, 451m, 10, "Order-10-2" },
                    { 23, 290m, 10, "Order-10-3" },
                    { 24, 451m, 10, "Order-10-4" },
                    { 25, 344m, 11, "Order-11-1" },
                    { 26, 50m, 11, "Order-11-2" },
                    { 27, 185m, 11, "Order-11-3" },
                    { 28, 154m, 12, "Order-12-1" },
                    { 29, 481m, 12, "Order-12-2" },
                    { 30, 175m, 13, "Order-13-1" },
                    { 31, 44m, 13, "Order-13-2" },
                    { 32, 116m, 14, "Order-14-1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
