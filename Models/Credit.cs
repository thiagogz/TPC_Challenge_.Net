using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Creditos")]
    public class Credit
    {
        [Key]
        public int CreditID { get; set; }
        [Required]
        [Column("Valor_do_Credito")]
        public long ValorCredito { get; set; }
        [Required]
        [Column("Data_do_Credito")]
        public DateOnly DataCredito { get; set; }
        [Required]
        [Column("Data_de_Expiracao")]
        public DateOnly DataExpiracao { get; set; }
        [Required]
        [Column("Status_do_Credito")]
        public char StatusCredito { get; set; }
    }
}
