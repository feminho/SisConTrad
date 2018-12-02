using Microsoft.EntityFrameworkCore.Migrations;

namespace SisConTrad.Infrastructure.Migrations
{
    public partial class updateClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Clients",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Clients");
        }
    }
}
