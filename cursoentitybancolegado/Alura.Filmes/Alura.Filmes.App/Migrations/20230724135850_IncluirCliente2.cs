using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Alura.Filmes.App.Migrations
{
    public partial class IncluirCliente2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UltimoNome",
                table: "customer",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "PrimeiroNome",
                table: "customer",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "customer",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "customer",
                newName: "active");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "customer",
                type: "varchar(45)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "customer",
                type: "varchar(45)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "customer",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_update",
                table: "customer",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "last_update",
                table: "customer");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "customer",
                newName: "UltimoNome");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "customer",
                newName: "PrimeiroNome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "customer",
                newName: "Ativo");

            migrationBuilder.AlterColumn<string>(
                name: "UltimoNome",
                table: "customer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimeiroNome",
                table: "customer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "customer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);
        }
    }
}
