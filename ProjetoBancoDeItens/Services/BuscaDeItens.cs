
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoBancoDeItens.Data;
using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Model;
using ProjetoBancoDeItens.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Services
{
    public class BuscaDeItens : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public BuscaDeItens(
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }

        public List<IdNomeDTO> Pesquisar(string ConteudoBusca, string usuarioId)
        {
            BuscaDTO Busca = new BuscaDTO();
            
            var unidadesCurricularesDoUsuario = new UsuarioNaUnidadeCurricularRepository(_db).BuscarComUsuario(usuarioId);
            return  new ConteudoItemRepository(_db).BuscarPesquisa(ConteudoBusca, unidadesCurricularesDoUsuario);
        }
    }
}
