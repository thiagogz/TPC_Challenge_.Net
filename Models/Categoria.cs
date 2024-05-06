using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required]
        [Column("Nome_Categoria")]
        public string NomeCategoria { get; set; }
        [Required]
        [Column("Descricao_Categoria")]
        public string DescricaoCategoria { get; set; }
        [Required]
        [Column("Ativo")]
        public char Ativo { get; set; }
    }
}
