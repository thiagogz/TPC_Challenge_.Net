using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Compras")]
    public class Compras
    {
        [Key]
        public int ComprasID { get; set; }
        public ICollection<Loja> Loja { get; set; }
        public ICollection<Users> Users { get; set; }
        [Required]
        [Column("Valor_da_Compra")]
        public long ValorCompra { get; set; }
        [Required]
        [Column("Data_da_Compra")]
        public DateOnly DataCompra { get; set; }
    }
}
