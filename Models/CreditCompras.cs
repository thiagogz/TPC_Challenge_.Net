using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Credit_Compras")]
    public class CreditCompras
    {
        [Key]
        public int CreditComprasID { get; set; }
        public required ICollection<Credit> Credit { get; set; }
        public required ICollection<Compras> Compras { get; set; }
    }
}
