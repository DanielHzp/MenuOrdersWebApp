using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPurchaseOrdersApp.Migrations
{
    /// <inheritdoc />
    public partial class addedBurgerDBOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurgerDBName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalDBPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOrders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuOrders");
        }
    }
}
