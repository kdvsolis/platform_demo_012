using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalOrderAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                });

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
                    { 1, 107m, 1, "Order-1-1" },
                    { 2, 27m, 1, "Order-1-2" },
                    { 3, 348m, 4, "Order-4-1" },
                    { 4, 184m, 4, "Order-4-2" },
                    { 5, 472m, 6, "Order-6-1" },
                    { 6, 330m, 6, "Order-6-2" },
                    { 7, 255m, 7, "Order-7-1" },
                    { 8, 199m, 7, "Order-7-2" },
                    { 9, 276m, 7, "Order-7-3" },
                    { 10, 431m, 8, "Order-8-1" },
                    { 11, 411m, 8, "Order-8-2" },
                    { 12, 164m, 8, "Order-8-3" },
                    { 13, 229m, 8, "Order-8-4" },
                    { 14, 26m, 9, "Order-9-1" },
                    { 15, 288m, 11, "Order-11-1" },
                    { 16, 401m, 12, "Order-12-1" },
                    { 17, 469m, 12, "Order-12-2" },
                    { 18, 429m, 12, "Order-12-3" },
                    { 19, 267m, 13, "Order-13-1" },
                    { 20, 293m, 14, "Order-14-1" },
                    { 21, 491m, 14, "Order-14-2" },
                    { 22, 36m, 14, "Order-14-3" },
                    { 23, 93m, 15, "Order-15-1" },
                    { 24, 355m, 15, "Order-15-2" }
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
