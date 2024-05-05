using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Pontos_Compra")]
    public class PontosCompra
    {
        [Key]
        public int PontosCompraID { get; set; }
        public required ICollection<Compras> Compras { get; set; }
        public required ICollection<Pontos> Pontos { get; set; }
    }
}
