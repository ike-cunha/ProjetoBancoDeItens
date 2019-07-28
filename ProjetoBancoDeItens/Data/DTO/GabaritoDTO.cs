using ProjetoBancoDeItens.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.DTO
{

    public class AlternativaItemDTO : ItemIdDTO
    {
        public Byte[] Texto { get; set; }
        public Byte[] Imagem { get; set; }
        public string AlternativaString64 { get; set; }
        public Constantes.Alternativa Posicao { get; set; }
        public Constantes.Alternativa Resposta { get; set; }
    }

    public class AlternativaListaDTO
    {
        public List<AlternativaItemDTO> Estrutura { get; set; }
        public bool IsImage { get; set; }
    }

}
