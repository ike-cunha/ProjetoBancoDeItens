using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjetoBancoDeItens.Data;
using ProjetoBancoDeItens.Data.Model;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoBancoDeItens.Data.DTO;
using System.Collections.Generic;
using ProjetoBancoDeItens.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBancoDeItens.Pages
{
    [Authorize]
    public class HomeModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeModel(
            ILogger<HomeModel> logger,
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _db = db;
            _userManager = userManager;
        }

        [BindProperty]
        public BuscaDTO Busca { get; set; }

        public string ConteudoBusca { get; set; }

        public string ReturnUrl { get; set; }

        public async Task OnGet()
        {
            var usuario = await GetCurrentUserAsync();

            //Último 10 itens inseridos pelo usuário
            int[] ultimosInseridos = new ItemRepository(_db).BuscarIdUltimasInsercoesPorUsuario(usuario?.Id);
            Busca = new BuscaDTO();
            Busca.Itens = new ConteudoItemRepository(_db).BuscarUltimasInsercoesPorItensId(ultimosInseridos).OrderByDescending(x => x.Id)
                                                                                                      .ToList();

        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public IActionResult OnPostAsync()
        {
            return RedirectToPage("ResultadoBusca", new { ConteudoBusca = Busca.ConteudoBusca });
            
        }


    }
}