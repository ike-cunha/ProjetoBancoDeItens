using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class UsuarioNoCurso
    {
        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser Usuario { get; set; }
        public string UsuarioId { get; set; }

        public virtual Curso Curso { get; set; }
        public int CursoId { get; set; }
    }
}
