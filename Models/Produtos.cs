using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Produtos")]
    public class Produtos
    {
        [Key]
        public int ProdutosID { get; set; }
        public ICollection<Loja> Loja { get; set; }
        public ICollection<Categoria> Categoria { get; set; }
        [Required]
        [Column("Nome_do_Produto")]
        public string NomeProduto { get; set; }
        [Required]
        [Column("Descricao_do_Produto")]
        public string DescricaoProduto { get; set; }
        [Required]
        [Column("Valor_do_Produto")]
        public Decimal ValorProduto { get; set; }
        [Required]
        [Column("Disponibilidade_do_Produto")]
        public bool DisponibilidadeProduto { get; set; }
    }
}
