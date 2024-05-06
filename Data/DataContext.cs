using Microsoft.EntityFrameworkCore;
using TPC_Challenge.Models;

namespace TPC_Challenge.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }

        public DbSet<Campanhas> Campanhas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cluster> Clusters { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<CreditCompras> CreditCompras { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Notificacoes> Notificacoes { get; set;}
        public DbSet<Pontos> Pontos { get; set; }
        public DbSet<PontosCompra> PontosCompras { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<UserCluster> UserClusters { get; set; }
        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<UserPDV> UserPDV { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
