using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Enum;
using ProjetoBancoDeItens.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class ConteudoItemRepository
    {
        private readonly ApplicationDbContext db;

        public ConteudoItemRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Adicionar(ConteudoItemModelDTO conteudoItem)
        {
            ConteudoItem conteudoNovoItem = new ConteudoItem
            {
                ItemId = conteudoItem.ItemId,
                Imagem = conteudoItem.TuplaTextoImagem.Imagem,
                Texto = conteudoItem.TuplaTextoImagem.Texto,
                Posicao = conteudoItem.Posicao
            };

            db.ConteudoItem.Add(conteudoNovoItem);
            db.SaveChanges();
        }

        /// <summary>
        /// Busca os IDs dos últimos 10 itens inseridos
        /// </summary>
        /// <param name="itensId">itens buscados</param>
        /// <returns></returns>
        public IdNomeDTO[] BuscarUltimasInsercoesPorItensId(int[] itensId)
        {
            return db.ConteudoItem.Where(i => itensId.Contains(i.ItemId))
                                  .Where(i => i.Posicao == Enum.Constantes.Posicao.Comando)
                                  .Select(p => new IdNomeDTO
                                  {
                                      Id = p.ItemId,
                                      Nome = p.Texto.ToString(),
                                  })
                                  .ToArray();
        }

        /// <summary>
        /// Busca item que contenha o termo pesquisado.
        /// </summary>
        /// <param name="conteudoBusca">Termo pesquisado</param>
        /// <returns></returns>
        public List<IdNomeDTO> BuscarPesquisa(string conteudoBusca, int[] unidadesCurricularesDoUsuario)
        {
            return db.ConteudoItem.Where(i => i.Texto.ToString().Contains(conteudoBusca))
                                  .Where(i => i.Item.Ativo)
                                  .Where(i => unidadesCurricularesDoUsuario.Contains(i.Item.UnidadeCurricularId))
                                  .Where(i => i.Posicao == Enum.Constantes.Posicao.Comando)
                                  .Select(c => new IdNomeDTO
                                  {
                                      Id = c.ItemId,
                                      Nome = c.Texto.ToString()
                                  })
                                  .ToList();
        }

        public string BuscarComando(int itemId)
        {
            return db.ConteudoItem.Where(i => i.ItemId == itemId)
                                  .Where(i => i.Posicao == Enum.Constantes.Posicao.Comando)
                                  .Select(p => p.Texto.ToString())
                                  .FirstOrDefault();
        }

        /// <summary>
        /// Busca conteúdo do suporte, seja de texto ou de imagem.
        /// </summary>
        /// <param name="itemId">Id do item</param>
        /// <returns></returns>
        public Tuple<byte[], byte[]> BuscarSuporte(int itemId)
        {
            return db.ConteudoItem.Where(i => i.ItemId == itemId)
                                  .Where(i => i.Posicao == Enum.Constantes.Posicao.Suporte)
                                  .Select(p => new
                                  {
                                     p.Texto,
                                     p.Imagem
                                  }).AsEnumerable()
                                  .Select(p => new Tuple<byte[], byte[]>(p.Texto, p.Imagem))
                                  .FirstOrDefault();
        }

        public string BuscarAutor(int itemId)
        {
            return db.ConteudoItem.Where(i => i.ItemId == itemId)
                                  .Select(p => p.Item.Usuario.Nome)
                                  .FirstOrDefault();
        }
    }
}
