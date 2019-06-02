using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(120)")]
        public string Nome { get; set; }
    }
}
