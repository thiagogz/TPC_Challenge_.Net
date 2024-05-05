using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Usuarios_Cluster")]
    public class UserCluster
    {
        [Key]
        public int UserClusterID { get; set; }
        public ICollection<Cluster> Cluster { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
