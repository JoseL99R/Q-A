using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesPayment.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Payment",
                newName: "Pago");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pago",
                table: "Payment",
                newName: "Title");
        }
    }
}
