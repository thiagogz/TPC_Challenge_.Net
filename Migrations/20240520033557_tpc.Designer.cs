﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using TPC_Challenge.Data;

#nullable disable

namespace TPC_Challenge.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240520033557_tpc")]
    partial class tpc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TPC_Challenge.Models.Campanhas", b =>
                {
                    b.Property<int>("CampanhasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampanhasID"));

                    b.Property<string>("ConteudoCampanha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Conteudo_Campanha");

                    b.Property<string>("DescricaoCampanha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Descricao_Campanha");

                    b.Property<string>("TipoCanal")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Tipo_de_Canal");

                    b.Property<string>("TituloCampanha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Titulo_Campanha");

                    b.HasKey("CampanhasID");

                    b.ToTable("Tabela_Campanhas");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaID"));

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Ativo");

                    b.Property<string>("DescricaoCategoria")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Descricao_Categoria");

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_Categoria");

                    b.Property<int?>("ProdutosProdutoID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CategoriaID");

                    b.HasIndex("ProdutosProdutoID");

                    b.ToTable("Tabela_Categoria");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Cluster", b =>
                {
                    b.Property<int>("ClusterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClusterID"));

                    b.Property<int?>("CampanhasID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DescricaoCluster")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Descricao_Cluster");

                    b.Property<string>("NomeCluster")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_Cluster");

                    b.Property<int?>("UserClusterID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("ClusterID");

                    b.HasIndex("CampanhasID");

                    b.HasIndex("UserClusterID");

                    b.ToTable("Tabela_Cluster");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Compras", b =>
                {
                    b.Property<int>("ComprasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComprasID"));

                    b.Property<int?>("CreditComprasID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DataCompra")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_da_Compra");

                    b.Property<int?>("PontosCompraID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<long>("ValorCompra")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("Valor_da_Compra");

                    b.HasKey("ComprasID");

                    b.HasIndex("CreditComprasID");

                    b.HasIndex("PontosCompraID");

                    b.ToTable("Tabela_Compras");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Credit", b =>
                {
                    b.Property<int>("CreditID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditID"));

                    b.Property<int?>("CreditComprasID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DataCredito")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_do_Credito");

                    b.Property<string>("DataExpiracao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_de_Expiracao");

                    b.Property<string>("StatusCredito")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Status_do_Credito");

                    b.Property<long>("ValorCredito")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("Valor_do_Credito");

                    b.HasKey("CreditID");

                    b.HasIndex("CreditComprasID");

                    b.ToTable("Tabela_Creditos");
                });

            modelBuilder.Entity("TPC_Challenge.Models.CreditCompras", b =>
                {
                    b.Property<int>("CreditComprasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditComprasID"));

                    b.HasKey("CreditComprasID");

                    b.ToTable("Tabela_Credit_Compras");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Loja", b =>
                {
                    b.Property<int>("LojaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LojaID"));

                    b.Property<string>("CepLoja")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CEP_da_Loja");

                    b.Property<string>("ComplementoLoja")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Complemento_da_Loja");

                    b.Property<int?>("ComprasID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EnderecoLoja")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Endereco_da_Loja");

                    b.Property<string>("LojaAtiva")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Loja_Ativa");

                    b.Property<string>("NomeLoja")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_da_Loja");

                    b.Property<int?>("NotificacoesID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("NumeroLoja")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Numero_da_loja");

                    b.Property<int?>("ProdutosProdutoID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("UserPdvID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("LojaID");

                    b.HasIndex("ComprasID");

                    b.HasIndex("NotificacoesID");

                    b.HasIndex("ProdutosProdutoID");

                    b.HasIndex("UserPdvID");

                    b.ToTable("Tabela_Loja");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Notificacoes", b =>
                {
                    b.Property<int>("NotificacoesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificacoesID"));

                    b.Property<string>("DataNotificacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_da_Notificacao");

                    b.Property<string>("MensagemNotificacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Mensagem_da_Notificacao");

                    b.Property<string>("TituloNotificacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Titulo_da_Notificacao");

                    b.HasKey("NotificacoesID");

                    b.ToTable("Tabela_Notificacoes");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Pontos", b =>
                {
                    b.Property<int>("PontosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PontosID"));

                    b.Property<string>("DataCredito")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_do_Credito");

                    b.Property<string>("DataExpiracao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_da_Expiracao");

                    b.Property<int?>("PontosCompraID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("StatusPontos")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Status_Pontos");

                    b.Property<int>("ValorPontos")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Valor_de_Pontos");

                    b.HasKey("PontosID");

                    b.HasIndex("PontosCompraID");

                    b.ToTable("Tabela_Pontos");
                });

            modelBuilder.Entity("TPC_Challenge.Models.PontosCompra", b =>
                {
                    b.Property<int>("PontosCompraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PontosCompraID"));

                    b.HasKey("PontosCompraID");

                    b.ToTable("Tabela_Pontos_Compra");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Produtos", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoID"));

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Descricao_do_Produto");

                    b.Property<string>("DisponibilidadeProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Disponibilidade_do_Produto");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_do_Produto");

                    b.Property<long>("ValorProduto")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("Valor_do_Produto");

                    b.HasKey("ProdutoID");

                    b.ToTable("Tabela_Produto");
                });

            modelBuilder.Entity("TPC_Challenge.Models.UserCluster", b =>
                {
                    b.Property<int>("UserClusterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserClusterID"));

                    b.HasKey("UserClusterID");

                    b.ToTable("Tabela_Usuarios_Cluster");
                });

            modelBuilder.Entity("TPC_Challenge.Models.UserMaster", b =>
                {
                    b.Property<int>("UserMasterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserMasterID"));

                    b.Property<string>("CadastroAtivo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Cadastro_Ativo");

                    b.Property<int?>("CampanhasID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DataRegistro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_de_Registro");

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Email_do_Usuario");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_do_Usuario");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Senha_do_Usuario");

                    b.Property<string>("SobrenomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Sobrenome_do_Usuario");

                    b.HasKey("UserMasterID");

                    b.HasIndex("CampanhasID");

                    b.ToTable("Tabela_Usuarios_Master");
                });

            modelBuilder.Entity("TPC_Challenge.Models.UserPDV", b =>
                {
                    b.Property<int>("UserPdvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPdvID"));

                    b.Property<string>("CadastroAtivo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Cadastro_Ativo");

                    b.Property<string>("DataRegistro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("Data_de_Registro");

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Email_do_Usuario");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_do_Usuario");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Senha_do_Usuario");

                    b.Property<string>("SobrenomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Sobrenome_do_Usuario");

                    b.HasKey("UserPdvID");

                    b.ToTable("Tabela_Usuarios_PDV");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsersID"));

                    b.Property<string>("CadastroAtivo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("Cadastro_Ativo");

                    b.Property<string>("ComplementoEndereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Complemento_do_Endereco");

                    b.Property<int?>("ComprasID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Email_do_Usuario");

                    b.Property<string>("EnderecoUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Endereco_do_Usuario");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_do_Usuario");

                    b.Property<int>("NumeroEndereco")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Numero_do_Endereco");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Senha_do_Usuario");

                    b.Property<string>("SobrenomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Sobrenome_do_Usuario");

                    b.Property<string>("TelefoneUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Telefone_do_Usuario");

                    b.Property<int?>("UserClusterID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("UsersID");

                    b.HasIndex("ComprasID");

                    b.HasIndex("UserClusterID");

                    b.ToTable("Tabela_Usuarios");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Categoria", b =>
                {
                    b.HasOne("TPC_Challenge.Models.Produtos", null)
                        .WithMany("Categoria")
                        .HasForeignKey("ProdutosProdutoID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Cluster", b =>
                {
                    b.HasOne("TPC_Challenge.Models.Campanhas", null)
                        .WithMany("Cluster")
                        .HasForeignKey("CampanhasID");

                    b.HasOne("TPC_Challenge.Models.UserCluster", null)
                        .WithMany("Cluster")
                        .HasForeignKey("UserClusterID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Compras", b =>
                {
                    b.HasOne("TPC_Challenge.Models.CreditCompras", null)
                        .WithMany("Compras")
                        .HasForeignKey("CreditComprasID");

                    b.HasOne("TPC_Challenge.Models.PontosCompra", null)
                        .WithMany("Compras")
                        .HasForeignKey("PontosCompraID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Credit", b =>
                {
                    b.HasOne("TPC_Challenge.Models.CreditCompras", null)
                        .WithMany("Credit")
                        .HasForeignKey("CreditComprasID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Loja", b =>
                {
                    b.HasOne("TPC_Challenge.Models.Compras", null)
                        .WithMany("Loja")
                        .HasForeignKey("ComprasID");

                    b.HasOne("TPC_Challenge.Models.Notificacoes", null)
                        .WithMany("Loja")
                        .HasForeignKey("NotificacoesID");

                    b.HasOne("TPC_Challenge.Models.Produtos", null)
                        .WithMany("Loja")
                        .HasForeignKey("ProdutosProdutoID");

                    b.HasOne("TPC_Challenge.Models.UserPDV", null)
                        .WithMany("Loja")
                        .HasForeignKey("UserPdvID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Pontos", b =>
                {
                    b.HasOne("TPC_Challenge.Models.PontosCompra", null)
                        .WithMany("Pontos")
                        .HasForeignKey("PontosCompraID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.UserMaster", b =>
                {
                    b.HasOne("TPC_Challenge.Models.Campanhas", null)
                        .WithMany("UserMaster")
                        .HasForeignKey("CampanhasID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Users", b =>
                {
                    b.HasOne("TPC_Challenge.Models.Compras", null)
                        .WithMany("Users")
                        .HasForeignKey("ComprasID");

                    b.HasOne("TPC_Challenge.Models.UserCluster", null)
                        .WithMany("Users")
                        .HasForeignKey("UserClusterID");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Campanhas", b =>
                {
                    b.Navigation("Cluster");

                    b.Navigation("UserMaster");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Compras", b =>
                {
                    b.Navigation("Loja");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TPC_Challenge.Models.CreditCompras", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Credit");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Notificacoes", b =>
                {
                    b.Navigation("Loja");
                });

            modelBuilder.Entity("TPC_Challenge.Models.PontosCompra", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Pontos");
                });

            modelBuilder.Entity("TPC_Challenge.Models.Produtos", b =>
                {
                    b.Navigation("Categoria");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("TPC_Challenge.Models.UserCluster", b =>
                {
                    b.Navigation("Cluster");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TPC_Challenge.Models.UserPDV", b =>
                {
                    b.Navigation("Loja");
                });
#pragma warning restore 612, 618
        }
    }
}
