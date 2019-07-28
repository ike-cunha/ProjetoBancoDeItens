using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Enum;
using ProjetoBancoDeItens.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class AlternativaItemRepository
    {
        private readonly ApplicationDbContext db;

        public AlternativaItemRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Adicionar(List<AlternativaItemDTO> listaAlternativasItem)
        {
            List<AlternativaItem> listaAlternativasItemParaBanco = new List<AlternativaItem>();
            foreach (var alternativaItem in listaAlternativasItem)
            {
                listaAlternativasItemParaBanco.Add(new AlternativaItem
                {
                    ItemId = alternativaItem.ItemId,
                    Imagem = alternativaItem.Imagem,
                    Texto = alternativaItem.Texto,
                    Posicao = alternativaItem.Posicao
                });
            }

            db.AlternativaItem.AddRange(listaAlternativasItemParaBanco);
            db.SaveChanges();
        }

        public List<AlternativaItemDTO> BuscarAlternativasEPosicoes(int itemId)
        {
            return db.AlternativaItem.Where(i => i.ItemId == itemId)
                                   .Select(p => new AlternativaItemDTO
                                   {
                                       Imagem = p.Imagem,
                                       Texto = p.Texto,
                                       Posicao = p.Posicao
                                   })
                                   .ToList();
        }
    }
}
