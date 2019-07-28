using ProjetoBancoDeItens.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class UnidadeCurricularRepository
    {
        private readonly ApplicationDbContext db;

        public UnidadeCurricularRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<IdNomeDTO> BuscarNomeComId(int[] unidadesCurricularesIds)
        {
            return db.UnidadeCurricular.Where(u => unidadesCurricularesIds.Contains(u.Id))
                                       .Select(p => new IdNomeDTO
                                       {
                                           Id = p.Id,
                                           Nome = p.Nome
                                       }).ToList();
        }

        public List<IdNomeDTO> BuscarComCursoId(int[] cursosIds)
        {
            return db.UnidadeCurricular.Where(u => cursosIds.Contains(u.Id))
                                       .Select(p => new IdNomeDTO
                                       {
                                           Id = p.Id,
                                           Nome = p.Nome
                                       })
                                       .ToList();
        }
    }
}
