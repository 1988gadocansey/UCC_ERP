using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCC_ERP.Infrastructure.Migrations
{
    public partial class SampleMigration128121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Uuid",
                table: "Colleges",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uuid",
                table: "Colleges");
        }
    }
}
