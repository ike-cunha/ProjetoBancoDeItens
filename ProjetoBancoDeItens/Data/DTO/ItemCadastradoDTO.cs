using System.Collections.Generic;
using ProjetoBancoDeItens.Data.Enum;

namespace ProjetoBancoDeItens.Data.DTO
{
    public class ItemCadastradoDTO
    {
        public ImagemTextoDTO Suporte { get; set; }
        public string Comando { get; set; }
        public ConteudoEPosicaoAlternativasDTO[] Alternativas { get; set; }
        public string Gabarito { get; set; }
        public string[] ListaAlternativas = new[] { "A", "B", "C", "D", "E", };
        public int[] Competencias { get; set; }
        public int UnidadeCurricular { get; set; }
        public Constantes.Nivel Nivel { get; set; }

        public ItemCadastradoDTO()
        {
            this.Suporte = new ImagemTextoDTO();
            //this.Alternativas = new List<ConteudoEPosicaoAlternativasDTO>();
        }
    }

    public class ConteudoEPosicaoAlternativasDTO
    {
        public ImagemTextoDTO Conteudo { get; set; }
        public Constantes.Alternativa Posicao { get; set; }
    }
}
