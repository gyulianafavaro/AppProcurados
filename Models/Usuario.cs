using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiMissing.Models
{
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome Completo")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuario")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioTelefone")]
        [Display(Name = "Telefone do Usuario")]
        public string UsuarioTelefone { get; set; } = string.Empty;

        [Column("UsuarioPassword")]
        [Display(Name = "Senha do Usuario")]
        public string UsuarioPassword { get; set; } = string.Empty;
    }
}
