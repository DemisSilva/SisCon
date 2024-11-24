using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisCon.Migrations
{
    public partial class EntidadeProfissional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PROFISSIONAL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PROFISSIONAL", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFISSIONAL_CRM",
                table: "TB_PROFISSIONAL",
                column: "CRM",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PROFISSIONAL");
        }
    }
}
