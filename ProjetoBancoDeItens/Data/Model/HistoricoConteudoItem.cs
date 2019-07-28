using ProjetoBancoDeItens.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class HistoricoConteudoItem
    {
        [Key]
        public int Id { get; set; }

        public virtual ConteudoItem ConteudoItem { get; set; }

        [Required]
        public int ConteudoItemId { get; set; }

        public byte[] Texto { get; set; }
        public byte[] Imagem { get; set; }
        public Constantes.Posicao Posicao { get; set; }

        [Required]
        public DateTime DataAlteracao { get; set; }
    }
}
