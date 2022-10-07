using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioPottencial.Migrations
{
    public partial class NovaTabelaVendedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemVendido",
                table: "Vendedores",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemVendido",
                table: "Vendedores");
        }
    }
}
