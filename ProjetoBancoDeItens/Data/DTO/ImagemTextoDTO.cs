using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.DTO
{
    public class ImagemTextoDTO
    {
        public IFormFile Imagem { get; set; }
        public string Texto { get; set; }
    }
}
