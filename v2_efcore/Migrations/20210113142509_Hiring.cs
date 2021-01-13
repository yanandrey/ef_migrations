using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace v2_efcore.Migrations
{
    public partial class Hiring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hirings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Beginning = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Department = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Function = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hirings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hirings_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hirings_StaffId",
                table: "Hirings",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hirings");
        }
    }
}
