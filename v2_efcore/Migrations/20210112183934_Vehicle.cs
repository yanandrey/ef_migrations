using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace v2_efcore.Migrations
{
    public partial class Vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Plate = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Color = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
