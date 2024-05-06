using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Loja")]
    public class Loja
    {
        [Key]
        public int LojaID { get; set; }
        [Required]
        [Column("Nome_da_Loja")]
        public string NomeLoja { get; set; }
        [Required]
        [Column("Endereco_da_Loja")]
        public string EnderecoLoja { get; set; }
        [Required]
        [Column("Numero_da_loja")]
        public int NumeroLoja { get; set; }
        [Required]
        [Column("Complemento_da_Loja")]
        public string ComplementoLoja { get; set; }
        [Required]
        [Column("CEP_da_Loja")]
        public string CepLoja { get; set; }
        [Required]
        [Column("Loja_Ativa")]
        public char LojaAtiva { get; set; }
    }
}
