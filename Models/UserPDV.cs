using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Usuarios_PDV")]
    public class UserPDV
    {
        [Key]
        public int UserPdvID { get; set; }
        public ICollection<Loja> Loja { get; set; }
        [Required]
        [Column("Nome_do_Usuario")]
        public string NomeUsuario { get; set; }
        [Required]
        [Column("Sobrenome_do_Usuario")]
        public string SobrenomeUsuario { get; set; }
        [Required]
        [Column("Email_do_Usuario")]
        public string EmailUsuario { get; set; }
        [Required]
        [Column("Senha_do_Usuario")]
        public string SenhaUsuario { get; set; }
        [Required]
        [Column("Data_de_Registro")]
        public DateOnly DataRegistro { get; set; }
        [Required]
        [Column("Cadastro_Ativo")]
        public bool CadastroAtivo { get; set; }
    }
}
