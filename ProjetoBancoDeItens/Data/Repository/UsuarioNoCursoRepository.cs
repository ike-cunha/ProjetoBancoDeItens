using ProjetoBancoDeItens.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class UsuarioNoCursoRepository
    {

        private readonly ApplicationDbContext db;

        public UsuarioNoCursoRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void AdicionarLista(UsuarioNoCurso[] listaUsuariosNoCurso)
        {
            db.UsuarioNoCurso.AddRangeAsync(listaUsuariosNoCurso);
            db.SaveChanges();
        }
    }
}
