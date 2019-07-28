using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ProjetoBancoDeItens.Data;
using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Model;
using ProjetoBancoDeItens.Data.Repository;
using ProjetoBancoDeItens.Services;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoBancoDeItens.Pages
{
    public class ResultadoBuscaModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ResultadoBuscaModel(
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }

        [BindProperty]
        public BuscaDTO Busca { get; set; }

        public async Task OnGet(string ConteudoBusca)
        {
            Busca = new BuscaDTO();
            ApplicationUser usuario = await GetCurrentUserAsync();
            Busca.Itens = new BuscaDeItens(_db, _userManager).Pesquisar(ConteudoBusca, usuario?.Id).ToList();
        }

        public async Task<IActionResult> OnPost(string ConteudoBusca)
        {
            Busca = new BuscaDTO();
            ApplicationUser usuario = await GetCurrentUserAsync();
            Busca.Itens = new BuscaDeItens(_db, _userManager).Pesquisar(ConteudoBusca, usuario?.Id).ToList();
            return Page();
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public IActionResult OnPostVisualizar(int itemId)
        {
            var dadosItens = new ItemModalDTO();

            ConteudoItemRepository conteudoItemRepository = new ConteudoItemRepository(_db);
            dadosItens.Comando = conteudoItemRepository.BuscarComando(itemId);
            dadosItens.Autor = conteudoItemRepository.BuscarAutor(itemId);

            //SUPORTE
            Tuple<Byte[], Byte[]> suporte = conteudoItemRepository.BuscarSuporte(itemId);
            //Caso Item1 (conteúdo em texto) seja diferente de nulo
            if (suporte.Item1 != null)
            {
                dadosItens.Suporte.Enunciado = ByteParaString(suporte.Item1);
                dadosItens.Suporte.IsImage = false;
            }
            else
            {
                dadosItens.Suporte.Enunciado = ByteParaBase64String(suporte.Item2);
                dadosItens.Suporte.IsImage = true;
            }

            //ALTERNATIVAS
            AlternativaItemRepository alternativaRepository = new AlternativaItemRepository(_db);
            dadosItens.Alternativas.Estrutura = alternativaRepository.BuscarAlternativasEPosicoes(itemId);
            if (dadosItens.Alternativas.Estrutura.Select(g => g.Texto).FirstOrDefault() != null)
            {
                dadosItens.Alternativas.Estrutura.ForEach(g => g.AlternativaString64 = ByteParaString(g.Texto));
                dadosItens.Alternativas.IsImage = false;
            }
            else
            {
                dadosItens.Alternativas.Estrutura.ForEach(g => g.AlternativaString64 = ByteParaBase64String(g.Imagem));
                dadosItens.Alternativas.IsImage = true;
            }

            dadosItens.RespostaCorreta = new ItemRepository(_db).BuscarRespostaCorreta(itemId);

            return new PartialViewResult
            {
                ViewName = "_ModalItem",
                ViewData = new ViewDataDictionary<ItemModalDTO>(ViewData, dadosItens)
            };
        }

        private string ByteParaBase64String(byte[] imagemEmByte)
        {
            return Convert.ToBase64String(imagemEmByte,
                                         Base64FormattingOptions.InsertLineBreaks);
            //return new FileContentResult(imagemEmByte, "image/jpg");

        }

        private string ByteParaString(byte[] textoEmByte)
        {
            return Encoding.UTF8.GetString(textoEmByte, 0, textoEmByte.Length);
        }
    }
}