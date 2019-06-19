using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.DTO
{
    public class BuscaDTO
    {
        public List<IdNomeDTO> Itens { get; set; }
        public string ConteudoBusca { get; set; }
    }
}
