using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.Repository
{
    public class UsuarioRepository
    {
        private readonly ApplicationDbContext db;

        public UsuarioRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
    }
}
