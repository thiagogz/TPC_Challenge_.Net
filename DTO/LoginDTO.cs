using System.ComponentModel.DataAnnotations;

namespace TPC_Challenge.DTO
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string EmailUsuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string SenhaUsuario { get; set; }
    }
}
