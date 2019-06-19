using ProjetoBancoDeItens.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class CursoRepository
    {
        private readonly ApplicationDbContext db;

        public CursoRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<IdNomeDTO> Listar()
        {
            return db.Curso.Select(c => new IdNomeDTO
            {
                Id = c.Id,
                Nome = c.Nome,
            }).ToList();
        }

    }
}
