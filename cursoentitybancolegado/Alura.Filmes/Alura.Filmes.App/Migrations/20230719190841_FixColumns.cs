using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Alura.Filmes.App.Migrations
{
    public partial class FixColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lenght",
                table: "film",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "realease_year",
                table: "film",
                newName: "release_year");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "length",
                table: "film",
                newName: "lenght");

            migrationBuilder.RenameColumn(
                name: "release_year",
                table: "film",
                newName: "realease_year");
        }
    }
}
