using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoBancoDeItens.Data.Enum;

namespace ProjetoBancoDeItens.Data.Model
{
    public class ConteudoItem
    {
        [Key]
        public int Id { get; set; }

        public byte[] Texto { get; set; }

        public byte[] Imagem { get; set; }

        [Required]
        public Constantes.Posicao Posicao { get; set; }

        public virtual Item Item { get; set; }
        [Required]
        public int ItemId { get; set; }

    }
}
