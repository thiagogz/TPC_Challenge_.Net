using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC_Challenge.Models
{
    [Table("Tabela_Notificacoes")]
    public class Notificacoes
    {
        [Key]
        public int NotificacoesID { get; set; }
        public required ICollection<Loja> Loja { get; set; }
        [Required]
        [Column("Titulo_da_Notificacao")]
        public string TituloNotificacao { get; set; }
        [Required]
        [Column("Mensagem_da_Notificacao")]
        public string MensagemNotificacao { get; set; }
        [Required]
        [Column("Data_da_Notificacao")]
        public DateOnly DataNotificacao { get; set; }
    }
}
