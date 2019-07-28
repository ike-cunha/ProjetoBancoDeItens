using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoBancoDeItens.Data;
using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Enum;
using ProjetoBancoDeItens.Data.Model;
using ProjetoBancoDeItens.Data.Repository;
using System.Linq;

namespace ProjetoBancoDeItens.Pages
{
    public class CadastroItemModel : PageModel
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;

        public CadastroItemModel(UserManager<ApplicationUser> userManager,
                                 ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [BindProperty]
        public ItemCadastradoDTO itemCadastrado { get; set; }

        public List<SelectListItem> ListaUnidadesCurriculares { get; set; }

        public async Task OnGet()
        {
            itemCadastrado = new ItemCadastradoDTO();

            ApplicationUser usuario = await GetCurrentUserAsync();
            int[] ListaUnidadesCurricularesDoUsuario = new UsuarioNaUnidadeCurricularRepository(_db).BuscarComUsuario(usuario?.Id);
            ListaUnidadesCurriculares = new UnidadeCurricularRepository(_db).BuscarNomeComId(ListaUnidadesCurricularesDoUsuario)
                                                                            .Select(c => new SelectListItem
                                                                            {
                                                                                Text = c.Nome,
                                                                                Value = c.Id.ToString(),
                                                                            }).ToList();
        }

        public async Task<IActionResult> OnPost()
        {
            var novoItemId = await MontarItem();
            MontarSuporte(novoItemId);
            MontarComando(novoItemId);
            MontarCompetencias(novoItemId);
            MontarAlternativa(novoItemId);

            return RedirectToPage("./Home");
        }



        private async Task<int> MontarItem()
        {
            if (Enum.TryParse(itemCadastrado.Gabarito, out Constantes.Alternativa gabarito))
            {
                ApplicationUser usuario = await GetCurrentUserAsync();
                ItemDTO novoItem = new ItemDTO
                {
                    UsuarioId = usuario?.Id,
                    UnidadeCurricularId = itemCadastrado.UnidadeCurricular,
                    Nivel = itemCadastrado.Nivel,
                    Gabarito = gabarito,
                    Aprovado = true,
                    Ativo = true,
                };
                return new ItemRepository(_db).Adicionar(novoItem);
            }

            return -1;
        }

        private void MontarSuporte(int itemId)
        {
            ConteudoItemModelDTO suporte = new ConteudoItemModelDTO
            {
                ItemId = itemId,
                Posicao = Constantes.Posicao.Suporte
            };

            if (itemCadastrado.Suporte.Imagem != null)
                suporte.TuplaTextoImagem = (null, ImageToArray(itemCadastrado.Suporte.Imagem));
            else
                suporte.TuplaTextoImagem = (Encoding.UTF8.GetBytes(itemCadastrado.Suporte.Texto), null);

            new ConteudoItemRepository(_db).Adicionar(suporte);
        }

        private void MontarComando(int itemId)
        {
            ConteudoItemModelDTO comando = new ConteudoItemModelDTO
            {
                ItemId = itemId,
                TuplaTextoImagem = (Encoding.UTF8.GetBytes(itemCadastrado.Comando), null),
                Posicao = Constantes.Posicao.Comando
            };

            new ConteudoItemRepository(_db).Adicionar(comando);
        }

        private void MontarAlternativa(int itemId)
        {
            List<AlternativaItemDTO> alternativasItemParaBanco = new List<AlternativaItemDTO>();

            foreach (ConteudoEPosicaoAlternativasDTO AlternativaCadastrada in itemCadastrado.Alternativas)
            {
                AlternativaItemDTO novaAlternativa = new AlternativaItemDTO
                {
                    Posicao = AlternativaCadastrada.Posicao,
                    ItemId = itemId,
                };

                novaAlternativa.Imagem = AlternativaCadastrada.Conteudo.Imagem != null ? ImageToArray(AlternativaCadastrada.Conteudo.Imagem) : null;
                novaAlternativa.Texto = AlternativaCadastrada.Conteudo.Texto != null ? Encoding.UTF8.GetBytes(AlternativaCadastrada.Conteudo.Texto) : null;
                
                alternativasItemParaBanco.Add(novaAlternativa);
            }

            new AlternativaItemRepository(_db).Adicionar(alternativasItemParaBanco);
        }

        private void MontarCompetencias(int itemId)
        {
            List<(int competencia, int itemId)> competenciasParaBanco = new List<(int, int)>();
            foreach (int competencia in itemCadastrado.Competencias)
            {
                competenciasParaBanco.Add((competencia, itemId));
            }

            new CompetenciaDoItemRepository(_db).Adicionar(competenciasParaBanco);
        }

        private byte[] ImageToArray(IFormFile image)
        {
            if (image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    try
                    {
                        image.CopyTo(ms);
                        return ms.ToArray();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    //string s = Convert.ToBase64String(fileBytes);
                }
            }

            return new byte[0];
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}