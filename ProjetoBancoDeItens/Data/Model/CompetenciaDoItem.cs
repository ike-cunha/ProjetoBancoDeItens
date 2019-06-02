using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class CompetenciaDoItem
    {
        [Key]
        public int Id { get; set; }

        public virtual Item Item { get; set; }

        [Required]
        public int ItemId { get; set; }

        public virtual Competencia Competencia { get; set; }

        [Required]
        public int CompetenciaId { get; set; }
    }
}
