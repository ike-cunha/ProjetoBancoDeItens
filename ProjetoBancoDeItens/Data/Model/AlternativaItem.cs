using ProjetoBancoDeItens.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Model
{
    public class AlternativaItem
    {
        [Key]
        public int Id { get; set; }

        public Byte[] Texto { get; set; }

        public Byte[] Imagem { get; set; }

        [Required]
        public Constantes.Alternativa Posicao { get; set; }

        [Required]
        public bool Resposta { get; set; }

        public virtual Item Item { get; set; }

        [Required]
        public int ItemId { get; set; }
    }
}
