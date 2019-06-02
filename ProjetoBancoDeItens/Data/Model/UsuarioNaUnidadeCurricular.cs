using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class UsuarioNaUnidadeCurricular
    {
        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser Usuario { get; set; }

        [Required]
        public string UsuarioId { get; set; }

        public virtual UnidadeCurricular UnidadeCurricular { get; set; }

        [Required]
        public int UnidadeCurricularId { get; set; }
    }
}
