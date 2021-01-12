using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace v1_efcore.Migrations
{
    public partial class Staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "id");

            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    last_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    password = table.Column<string>(type: "varchar(16)", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            migrationBuilder.RenameTable(
                name: "customer",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
