using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroCandidatura.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistroCandidatura",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "text", nullable: true),
                    SOBRENOME = table.Column<string>(type: "text", nullable: true),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    VAGA = table.Column<string>(type: "text", nullable: true),
                    PRETENSAO_SALARIAL = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroCandidatura", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroCandidatura");
        }
    }
}
