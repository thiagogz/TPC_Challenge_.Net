using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Pontos")]
    public class Pontos
    {
        [Key]
        public int PontosID { get; set; }
        [Required]
        [Column("Valor_de_Pontos")]
        public int ValorPontos { get; set; }
        [Required]
        [Column("Data_do_Credito")]
        public DateOnly DataCredito { get; set; }
        [Required]
        [Column("Data_da_Expiracao")]
        public DateOnly DataExpiracao { get; set; }
        [Required]
        [Column("Status_Pontos")]
        public char StatusPontos { get; set; }
    }
}
