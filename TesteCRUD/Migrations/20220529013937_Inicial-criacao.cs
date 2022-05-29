using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBeltApp.Migrations
{
    public partial class Inicialcriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aula",
                columns: table => new
                {
                    id_aula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_mestre = table.Column<int>(type: "int", nullable: false),
                    data_aula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    anotacao_aula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula", x => x.id_aula);
                });

            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    id_campeonato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_quarta = table.Column<int>(type: "int", nullable: false),
                    id_semi = table.Column<int>(type: "int", nullable: false),
                    id_final = table.Column<int>(type: "int", nullable: false),
                    id_vencedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.id_campeonato);
                });

            migrationBuilder.CreateTable(
                name: "FinalCampeonato",
                columns: table => new
                {
                    id_final = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_aluno1 = table.Column<int>(type: "int", nullable: false),
                    id_aluno2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalCampeonato", x => x.id_final);
                });

            migrationBuilder.CreateTable(
                name: "QuartasCampeonato",
                columns: table => new
                {
                    id_quarta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_aluno1 = table.Column<int>(type: "int", nullable: false),
                    id_aluno2 = table.Column<int>(type: "int", nullable: false),
                    id_aluno3 = table.Column<int>(type: "int", nullable: false),
                    id_aluno4 = table.Column<int>(type: "int", nullable: false),
                    id_aluno5 = table.Column<int>(type: "int", nullable: false),
                    id_aluno6 = table.Column<int>(type: "int", nullable: false),
                    id_aluno7 = table.Column<int>(type: "int", nullable: false),
                    id_aluno8 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuartasCampeonato", x => x.id_quarta);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    id_responsavel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.id_responsavel);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aula");

            migrationBuilder.DropTable(
                name: "Campeonato");

            migrationBuilder.DropTable(
                name: "FinalCampeonato");

            migrationBuilder.DropTable(
                name: "QuartasCampeonato");

            migrationBuilder.DropTable(
                name: "Responsavel");
        }
    }
}
