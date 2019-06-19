using ProjetoBancoDeItens.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class ItemRepository
    {
        private readonly ApplicationDbContext db;

        public ItemRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        /// <summary>
        /// Busca os IDs dos últimos 10 itens inseridos
        /// </summary>
        /// <returns></returns>
        public int[] BuscarIdUltimasInsercoesPorUsuario(string usuarioId)
        {
            return db.Item.Where(u => u.UsuarioId == usuarioId)
                   .OrderByDescending(o => o.Id)
                   .Take(10)
                   .Select(p => p.Id)
                   .ToArray();
        }
    }
}
