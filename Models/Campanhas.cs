using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Campanhas")]
    public class Campanhas
    {
        [Key]
        public int CampanhasID { get; set; }
        public required ICollection<UserMaster> UserMaster { get; set; }
        public required ICollection<Cluster> Cluster { get; set; }
        [Required]
        [Column("Titulo_Campanha")]
        public string TituloCampanha { get; set; }
        [Required]
        [Column("Conteudo_Campanha")]
        public string ConteudoCampanha { get; set; }
        [Required]
        [Column("Descricao_Campanha")]
        public string DescricaoCampanha { get; set; }
        [Required]
        [Column("Tipo_de_Canal")]
        public string TipoCanal { get; set; }
    }
}
