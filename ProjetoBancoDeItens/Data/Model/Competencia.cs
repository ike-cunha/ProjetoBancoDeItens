using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class Competencia
    {
       [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(3)")]
        public string Sigla { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        public string Descricao { get; set; }
    }
}
