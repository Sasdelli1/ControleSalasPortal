using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSalasPortal.Data.Migrations
{
    public partial class Turmas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Curso = table.Column<string>(nullable: true),
                    QuantidadeAluno = table.Column<int>(nullable: false),
                    Professor = table.Column<string>(nullable: true),
                    Sala = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
