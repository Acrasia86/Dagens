using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dagens.Migrations
{
    public partial class AddAdditionalProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromCountry",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Knockouts",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Losses",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalMatches",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wins",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "FromCountry",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Knockouts",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Losses",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "TotalMatches",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Article");
        }
    }
}
