using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPC_Challenge.DTO
{
    public class PontosDTO
    {
        [Required]
        public int ValorPontos { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DataCredito { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DataExpiracao { get; set; }
        [Required]
        public char StatusPontos { get; set; } = '1';
    }
}
