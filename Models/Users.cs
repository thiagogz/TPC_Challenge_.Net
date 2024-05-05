using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Usuarios")]
    public class Users
    {
        [Key]
        public int UsersID { get; set; }
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
        [Column("Telefone_do_Usuario")]
        public string TelefoneUsuario { get; set; }
        [Required]
        [Column("Endereco_do_Usuario")]
        public string EnderecoUsuario { get; set; }
        [Required]
        [Column("Numero_do_Endereco")]
        public int NumeroEndereco { get; set; }
        [Required]
        [Column("Complemento_do_Endereco")]
        public string ComplementoEndereco { get; set; }
        [Required]
        [Column("Cadastro_Ativo")]
        public bool CadastroAtivo { get; set; }
    }
}
