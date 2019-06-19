using ProjetoBancoDeItens.Data.DTO;
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

        /// <summary>
        /// Busca os IDs dos últimos 10 itens inseridos
        /// </summary>
        /// <returns></returns>
        public IdNomeDTO[] BuscarUltimasInsercoesPorItensId(int[] itensId)
        {
            return db.ConteudoItem.Where(u => itensId.Contains(u.ItemId))
                                  .Where(u => u.Posicao == Enum.Constantes.Posicao.Comando)
                                  .Select(p => new IdNomeDTO
                                  {
                                      Id = p.ItemId,
                                      Nome = p.Texto.ToString(),
                                  })
                                  .ToArray();
        }
    }
}
