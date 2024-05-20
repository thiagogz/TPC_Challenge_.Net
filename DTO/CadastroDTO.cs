using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPC_Challenge.DTO
{
    public class CadastroDTO
    {
        [Required]
        public string NomeUsuario { get; set; }
        [Required]
        public string SobrenomeUsuario { get; set; }
        [Required]
        [EmailAddress]
        public string EmailUsuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string SenhaUsuario { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string TelefoneUsuario { get; set; }
        [Required]
        public string EnderecoUsuario { get; set; }
        [Required]
        public int NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; } = string.Empty;
    }
}
