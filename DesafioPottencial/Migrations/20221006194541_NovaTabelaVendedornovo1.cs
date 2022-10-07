using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioPottencial.Migrations
{
    public partial class NovaTabelaVendedornovo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Vendedores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Vendedores");
        }
    }
}
