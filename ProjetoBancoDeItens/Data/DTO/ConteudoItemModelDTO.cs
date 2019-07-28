using ProjetoBancoDeItens.Data.Enum;
using System.Collections.Generic;

namespace ProjetoBancoDeItens.Data.DTO
{
    public class ConteudoItemModelDTO : ItemIdDTO
    {
        public (byte[] Texto, byte[] Imagem) TuplaTextoImagem { get; set; }
        public Constantes.Posicao Posicao { get; set; }
    }
}
