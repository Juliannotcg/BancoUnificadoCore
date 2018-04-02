using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BancoUnificadoCore.Infrastructure.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apresentante",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CodigoApresentante = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Documento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipoDocumento = table.Column<int>(type: "VARCHAR(10)", nullable: false),
                    Bairro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Logradouro = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    UF = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    SobreNome = table.Column<string>(type: "VARCHAR(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apresentante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Credor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Documento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipoDocumento = table.Column<int>(type: "VARCHAR(10)", nullable: false),
                    Bairro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Logradouro = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    UF = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    SobreNome = table.Column<string>(type: "VARCHAR(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Login = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titulo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Acao = table.Column<int>(type: "INT", nullable: false),
                    Aceite = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    ApresentanteId = table.Column<Guid>(nullable: true),
                    CredorId = table.Column<Guid>(nullable: true),
                    DataAcao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataProtesto = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataProtocolo = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Endosso = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Especie = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    FinsFalimentares = table.Column<bool>(type: "TINYINT", nullable: false),
                    Folha = table.Column<int>(type: "INT", nullable: false),
                    Livro = table.Column<int>(type: "INT", nullable: false),
                    MotivoProtesto = table.Column<int>(type: "INT", nullable: false),
                    NossoNumero = table.Column<int>(type: "INT", nullable: false),
                    Numero = table.Column<int>(type: "INT", nullable: false),
                    NumeroProtesto = table.Column<int>(type: "INT", nullable: false),
                    Protocolo = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Saldo = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Sequencial = table.Column<int>(type: "INT", nullable: false),
                    Valor = table.Column<decimal>(type: "DECIMAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titulo_Apresentante_ApresentanteId",
                        column: x => x.ApresentanteId,
                        principalTable: "Apresentante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titulo_Credor_CredorId",
                        column: x => x.CredorId,
                        principalTable: "Credor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CargaDiaria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    tituloId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaDiaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargaDiaria_Titulo_tituloId",
                        column: x => x.tituloId,
                        principalTable: "Titulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TituloId = table.Column<Guid>(nullable: true),
                    Documento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipoDocumento = table.Column<int>(type: "VARCHAR(10)", nullable: false),
                    Bairro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Logradouro = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    UF = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    SobreNome = table.Column<string>(type: "VARCHAR(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devedor_Titulo_TituloId",
                        column: x => x.TituloId,
                        principalTable: "Titulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargaDiaria_tituloId",
                table: "CargaDiaria",
                column: "tituloId");

            migrationBuilder.CreateIndex(
                name: "IX_Devedor_TituloId",
                table: "Devedor",
                column: "TituloId");

            migrationBuilder.CreateIndex(
                name: "IX_Titulo_ApresentanteId",
                table: "Titulo",
                column: "ApresentanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Titulo_CredorId",
                table: "Titulo",
                column: "CredorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargaDiaria");

            migrationBuilder.DropTable(
                name: "Devedor");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Titulo");

            migrationBuilder.DropTable(
                name: "Apresentante");

            migrationBuilder.DropTable(
                name: "Credor");
        }
    }
}
