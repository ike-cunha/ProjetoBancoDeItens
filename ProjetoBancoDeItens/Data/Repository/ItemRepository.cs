using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Enum;
using ProjetoBancoDeItens.Data.Model;
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

        public Constantes.Alternativa BuscarRespostaCorreta(int itemId)
        {
            return db.Item.Where(i => i.Id == itemId)
                          .Select(p => p.Gabarito)
                          .FirstOrDefault();
        }

        public int Adicionar(ItemDTO item)
        {
            Item novoItem = new Item
            {
                UsuarioId = item.UsuarioId,
                UnidadeCurricularId = item.UnidadeCurricularId,
                Nivel = item.Nivel,
                Gabarito = item.Gabarito,
                Aprovado = item.Aprovado,
                Ativo = item.Ativo,
            };

            db.Item.Add(novoItem);
            db.SaveChanges();

            return novoItem.Id;
        }

    }
}
