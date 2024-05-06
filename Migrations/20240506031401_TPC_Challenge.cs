using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPC_Challenge.Migrations
{
    /// <inheritdoc />
    public partial class TPC_Challenge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabela_Campanhas",
                columns: table => new
                {
                    CampanhasID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Titulo_Campanha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Conteudo_Campanha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao_Campanha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Tipo_de_Canal = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Campanhas", x => x.CampanhasID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Credit_Compras",
                columns: table => new
                {
                    CreditComprasID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Credit_Compras", x => x.CreditComprasID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Notificacoes",
                columns: table => new
                {
                    NotificacoesID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Titulo_da_Notificacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mensagem_da_Notificacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_da_Notificacao = table.Column<string>(type: "NVARCHAR2(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Notificacoes", x => x.NotificacoesID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Pontos_Compra",
                columns: table => new
                {
                    PontosCompraID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Pontos_Compra", x => x.PontosCompraID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Produto",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_do_Produto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao_do_Produto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Valor_do_Produto = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Disponibilidade_do_Produto = table.Column<string>(type: "NVARCHAR2(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Produto", x => x.ProdutoID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Usuarios_Cluster",
                columns: table => new
                {
                    UserClusterID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Usuarios_Cluster", x => x.UserClusterID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Usuarios_PDV",
                columns: table => new
                {
                    UserPdvID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sobrenome_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Senha_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_de_Registro = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    Cadastro_Ativo = table.Column<string>(type: "NVARCHAR2(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Usuarios_PDV", x => x.UserPdvID);
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Usuarios_Master",
                columns: table => new
                {
                    UserMasterID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sobrenome_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Senha_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Data_de_Registro = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    Cadastro_Ativo = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    CampanhasID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Usuarios_Master", x => x.UserMasterID);
                    table.ForeignKey(
                        name: "FK_Tabela_Usuarios_Master_Tabela_Campanhas_CampanhasID",
                        column: x => x.CampanhasID,
                        principalTable: "Tabela_Campanhas",
                        principalColumn: "CampanhasID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Creditos",
                columns: table => new
                {
                    CreditID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Valor_do_Credito = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Data_do_Credito = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    Data_de_Expiracao = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    Status_do_Credito = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    CreditComprasID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Creditos", x => x.CreditID);
                    table.ForeignKey(
                        name: "FK_Tabela_Creditos_Tabela_Credit_Compras_CreditComprasID",
                        column: x => x.CreditComprasID,
                        principalTable: "Tabela_Credit_Compras",
                        principalColumn: "CreditComprasID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Compras",
                columns: table => new
                {
                    ComprasID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Valor_da_Compra = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Data_da_Compra = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    CreditComprasID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    PontosCompraID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Compras", x => x.ComprasID);
                    table.ForeignKey(
                        name: "FK_Tabela_Compras_Tabela_Credit_Compras_CreditComprasID",
                        column: x => x.CreditComprasID,
                        principalTable: "Tabela_Credit_Compras",
                        principalColumn: "CreditComprasID");
                    table.ForeignKey(
                        name: "FK_Tabela_Compras_Tabela_Pontos_Compra_PontosCompraID",
                        column: x => x.PontosCompraID,
                        principalTable: "Tabela_Pontos_Compra",
                        principalColumn: "PontosCompraID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Pontos",
                columns: table => new
                {
                    PontosID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Valor_de_Pontos = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Data_do_Credito = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    Data_da_Expiracao = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    Status_Pontos = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    PontosCompraID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Pontos", x => x.PontosID);
                    table.ForeignKey(
                        name: "FK_Tabela_Pontos_Tabela_Pontos_Compra_PontosCompraID",
                        column: x => x.PontosCompraID,
                        principalTable: "Tabela_Pontos_Compra",
                        principalColumn: "PontosCompraID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Categoria",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_Categoria = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao_Categoria = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Ativo = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    ProdutosProdutoID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Categoria", x => x.CategoriaID);
                    table.ForeignKey(
                        name: "FK_Tabela_Categoria_Tabela_Produto_ProdutosProdutoID",
                        column: x => x.ProdutosProdutoID,
                        principalTable: "Tabela_Produto",
                        principalColumn: "ProdutoID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Cluster",
                columns: table => new
                {
                    ClusterID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_Cluster = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao_Cluster = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CampanhasID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserClusterID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Cluster", x => x.ClusterID);
                    table.ForeignKey(
                        name: "FK_Tabela_Cluster_Tabela_Campanhas_CampanhasID",
                        column: x => x.CampanhasID,
                        principalTable: "Tabela_Campanhas",
                        principalColumn: "CampanhasID");
                    table.ForeignKey(
                        name: "FK_Tabela_Cluster_Tabela_Usuarios_Cluster_UserClusterID",
                        column: x => x.UserClusterID,
                        principalTable: "Tabela_Usuarios_Cluster",
                        principalColumn: "UserClusterID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Loja",
                columns: table => new
                {
                    LojaID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_da_Loja = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Endereco_da_Loja = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Numero_da_loja = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Complemento_da_Loja = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CEP_da_Loja = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Loja_Ativa = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    ComprasID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NotificacoesID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ProdutosProdutoID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserPdvID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Loja", x => x.LojaID);
                    table.ForeignKey(
                        name: "FK_Tabela_Loja_Tabela_Compras_ComprasID",
                        column: x => x.ComprasID,
                        principalTable: "Tabela_Compras",
                        principalColumn: "ComprasID");
                    table.ForeignKey(
                        name: "FK_Tabela_Loja_Tabela_Notificacoes_NotificacoesID",
                        column: x => x.NotificacoesID,
                        principalTable: "Tabela_Notificacoes",
                        principalColumn: "NotificacoesID");
                    table.ForeignKey(
                        name: "FK_Tabela_Loja_Tabela_Produto_ProdutosProdutoID",
                        column: x => x.ProdutosProdutoID,
                        principalTable: "Tabela_Produto",
                        principalColumn: "ProdutoID");
                    table.ForeignKey(
                        name: "FK_Tabela_Loja_Tabela_Usuarios_PDV_UserPdvID",
                        column: x => x.UserPdvID,
                        principalTable: "Tabela_Usuarios_PDV",
                        principalColumn: "UserPdvID");
                });

            migrationBuilder.CreateTable(
                name: "Tabela_Usuarios",
                columns: table => new
                {
                    UsersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sobrenome_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Senha_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Endereco_do_Usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Numero_do_Endereco = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Complemento_do_Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cadastro_Ativo = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    ComprasID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserClusterID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_Usuarios", x => x.UsersID);
                    table.ForeignKey(
                        name: "FK_Tabela_Usuarios_Tabela_Compras_ComprasID",
                        column: x => x.ComprasID,
                        principalTable: "Tabela_Compras",
                        principalColumn: "ComprasID");
                    table.ForeignKey(
                        name: "FK_Tabela_Usuarios_Tabela_Usuarios_Cluster_UserClusterID",
                        column: x => x.UserClusterID,
                        principalTable: "Tabela_Usuarios_Cluster",
                        principalColumn: "UserClusterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Categoria_ProdutosProdutoID",
                table: "Tabela_Categoria",
                column: "ProdutosProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Cluster_CampanhasID",
                table: "Tabela_Cluster",
                column: "CampanhasID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Cluster_UserClusterID",
                table: "Tabela_Cluster",
                column: "UserClusterID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Compras_CreditComprasID",
                table: "Tabela_Compras",
                column: "CreditComprasID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Compras_PontosCompraID",
                table: "Tabela_Compras",
                column: "PontosCompraID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Creditos_CreditComprasID",
                table: "Tabela_Creditos",
                column: "CreditComprasID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Loja_ComprasID",
                table: "Tabela_Loja",
                column: "ComprasID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Loja_NotificacoesID",
                table: "Tabela_Loja",
                column: "NotificacoesID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Loja_ProdutosProdutoID",
                table: "Tabela_Loja",
                column: "ProdutosProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Loja_UserPdvID",
                table: "Tabela_Loja",
                column: "UserPdvID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Pontos_PontosCompraID",
                table: "Tabela_Pontos",
                column: "PontosCompraID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Usuarios_ComprasID",
                table: "Tabela_Usuarios",
                column: "ComprasID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Usuarios_UserClusterID",
                table: "Tabela_Usuarios",
                column: "UserClusterID");

            migrationBuilder.CreateIndex(
                name: "IX_Tabela_Usuarios_Master_CampanhasID",
                table: "Tabela_Usuarios_Master",
                column: "CampanhasID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabela_Categoria");

            migrationBuilder.DropTable(
                name: "Tabela_Cluster");

            migrationBuilder.DropTable(
                name: "Tabela_Creditos");

            migrationBuilder.DropTable(
                name: "Tabela_Loja");

            migrationBuilder.DropTable(
                name: "Tabela_Pontos");

            migrationBuilder.DropTable(
                name: "Tabela_Usuarios");

            migrationBuilder.DropTable(
                name: "Tabela_Usuarios_Master");

            migrationBuilder.DropTable(
                name: "Tabela_Notificacoes");

            migrationBuilder.DropTable(
                name: "Tabela_Produto");

            migrationBuilder.DropTable(
                name: "Tabela_Usuarios_PDV");

            migrationBuilder.DropTable(
                name: "Tabela_Compras");

            migrationBuilder.DropTable(
                name: "Tabela_Usuarios_Cluster");

            migrationBuilder.DropTable(
                name: "Tabela_Campanhas");

            migrationBuilder.DropTable(
                name: "Tabela_Credit_Compras");

            migrationBuilder.DropTable(
                name: "Tabela_Pontos_Compra");
        }
    }
}
