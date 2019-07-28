using System.Linq;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class UsuarioNaUnidadeCurricularRepository
    {
        private readonly ApplicationDbContext db;

        public UsuarioNaUnidadeCurricularRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public int[] BuscarComUsuario(string usuarioId)
        {
            return db.UsuarioNaUnidadeCurricular.Where(u => u.UsuarioId == usuarioId)
                                         .Select(p => p.UnidadeCurricularId)
                                         .ToArray();
        }

    }
}
