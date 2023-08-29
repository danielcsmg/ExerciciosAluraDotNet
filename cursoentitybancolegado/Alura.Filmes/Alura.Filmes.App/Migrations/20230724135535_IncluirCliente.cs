using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Alura.Filmes.App.Migrations
{
    public partial class IncluirCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "customer");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "last_update",
                table: "customer",
                newName: "create_date");

            migrationBuilder.AlterColumn<string>(
                name: "UltimoNome",
                table: "customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimeiroNome",
                table: "customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "customer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            migrationBuilder.RenameTable(
                name: "customer",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "UltimoNome",
                table: "Cliente",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "PrimeiroNome",
                table: "Cliente",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "Cliente",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "create_date",
                table: "Cliente",
                newName: "last_update");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Cliente",
                type: "varchar(45)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Cliente",
                type: "varchar(45)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Cliente",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");
        }
    }
}
