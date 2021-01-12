using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace v1_efcore.Migrations
{
    public partial class Hiring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hiring",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    beginning = table.Column<DateTime>(type: "datetime", nullable: false),
                    department = table.Column<string>(type: "varchar(25)", nullable: false),
                    function = table.Column<string>(type: "varchar(25)", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hiring", x => x.id);
                    table.ForeignKey(
                        name: "FK_hiring_staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "staff",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hiring_StaffId",
                table: "hiring",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hiring");
        }
    }
}
