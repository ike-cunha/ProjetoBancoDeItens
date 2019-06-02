using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class UnidadeCurricularNoCurso
    {
        [Key]
        public int Id { get; set; }

        public virtual Curso Curso { get; set; }

        [Required]
        public int CursoId { get; set; }

        public virtual UnidadeCurricular UnidadeCurricular { get; set; }

        [Required]
        public int UnidadeCurricularId { get; set; }

    }
}
