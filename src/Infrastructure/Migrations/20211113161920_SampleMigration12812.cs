using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCC_ERP.Infrastructure.Migrations
{
    public partial class SampleMigration12812 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OnCompleted",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnRegister",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnCompleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "OnRegister",
                table: "Students");
        }
    }
}
