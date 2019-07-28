using ProjetoBancoDeItens.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class CompetenciaDoItemRepository
    {
        private readonly ApplicationDbContext db;

        public CompetenciaDoItemRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Adicionar(List<(int competencia, int itemId)> competencias)
        {
            List<CompetenciaDoItem> competenciasParaBanco = new List<CompetenciaDoItem>();
            foreach (var competencia in competencias)
            {
                competenciasParaBanco.Add(new CompetenciaDoItem
                {
                    CompetenciaId = competencia.competencia,
                    ItemId = competencia.itemId
                });
            }

            db.CompetenciaDoItem.AddRange(competenciasParaBanco);
            db.SaveChanges();
        }
    }
}
