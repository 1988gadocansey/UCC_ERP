using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UCC_ERP.Infrastructure.Migrations
{
    public partial class SampleMigration1281211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Colleges");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Colleges");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Colleges",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Colleges",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Colleges",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Colleges",
                type: "text",
                nullable: true);
        }
    }
}
