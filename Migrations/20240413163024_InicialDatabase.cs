using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeLocacoes.Migrations
{
    /// <inheritdoc />
    public partial class InicialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPessoa = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CPF_CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderecosEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Brasil"),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false, defaultValue: "A"),
                    ClienteSN = table.Column<bool>(type: "bit", nullable: true),
                    FornecedorSN = table.Column<bool>(type: "bit", nullable: true),
                    TransportadoraSN = table.Column<bool>(type: "bit", nullable: true),
                    Contato1 = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Contato2 = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    PessoaRecado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Alteracao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecosEmpresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecosEmpresas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnderecosEmpresas_Empresas_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosEmpresas_EmpresaId",
                table: "EnderecosEmpresas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosEmpresas_EmpresaId1",
                table: "EnderecosEmpresas",
                column: "EmpresaId1",
                unique: true,
                filter: "[EmpresaId1] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnderecosEmpresas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
