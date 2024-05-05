using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Cluster")]
    public class Cluster
    {
        [Key]
        public int ClusterID { get; set; }
        [Required]
        [Column("Nome_Cluster")]
        public string NomeCluster { get; set; }
        [Required]
        [Column("Descricao_Cluster")]
        public string DescricaoCluster { get; set; }
    }
}
