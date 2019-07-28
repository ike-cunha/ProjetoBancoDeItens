using ProjetoBancoDeItens.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.DTO
{
    public class ItemModalDTO
    {
        public ItemModalDTO()
        {
            this.Suporte = new SuporteDTO();
            this.Alternativas = new AlternativaListaDTO();
        }

        public SuporteDTO Suporte { get; set; }
        public AlternativaListaDTO Alternativas { get; set; }
        public string Comando { get; set; }
        public Constantes.Alternativa RespostaCorreta { get; set; }
        public string Autor { get; set; }
    }
}
