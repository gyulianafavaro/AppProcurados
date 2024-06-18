using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiMissing.Models
{
    public class Observacoes
    {

        [Column("ObservacaoId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Observação Descrição")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Observação do Local")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Observação da Data")]
        public DateTime ObservacaoData { get; set; }


        [ForeignKey("PessoaId")]
        [Display(Name = "Código da Pessoa")]
        public int PessoaId { get; set; }

        public Pessoa? Pessoa { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Código do Usuário")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }


    }
}
