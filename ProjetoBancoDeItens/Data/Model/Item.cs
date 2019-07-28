using ProjetoBancoDeItens.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBancoDeItens.Data.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public virtual UnidadeCurricular UnidadeCurricular { get; set; }

        [Required]
        public int UnidadeCurricularId { get; set; }

        public virtual ApplicationUser Usuario { get; set; }

        [Required]
        public string UsuarioId { get; set; }

        [Required]
        public Constantes.Nivel Nivel { get; set; }

        public Constantes.Alternativa Gabarito { get; set; }

        [Required]
        public bool Aprovado { get; set; }

        public bool Ativo { get; set; }
    }
}
