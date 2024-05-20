using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPC_Challenge.DTO
{
    public class CreditDTO
    {
        [Required]
        public long ValorCredito { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DataCredito { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly DataExpiracao { get; set; }
        [Required]
        public char StatusCredito { get; set; } = '1';
    }
}
