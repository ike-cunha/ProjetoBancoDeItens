using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName = "VARCHAR(120)")]
        public string Nome { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        public string CPF { get; set; }

        [Column(TypeName = "VARCHAR(8)")]
        public string Matricula { get; set; }
    }
}
