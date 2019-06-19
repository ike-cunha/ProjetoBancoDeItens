using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjetoBancoDeItens.Data.DTO;
using ProjetoBancoDeItens.Data.Model;
using System.Linq;
using System.Collections.Generic;
using ProjetoBancoDeItens.Data.Repository;
using ProjetoBancoDeItens.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ProjetoBancoDeItens.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _db;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _db = db;
        }

        [BindProperty]
        public RegistroDTO usuario { get; set; }

        public List<SelectListItem> ListaCursos { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            ListaCursos = new CursoRepository(_db).Listar()
                                                .Select(c => new SelectListItem
                                                {
                                                    Text = c.Nome,
                                                    Value = c.Id.ToString(),
                                                }).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/home");
            if (ModelState.IsValid)
            {
                ApplicationUser dadosUsuario = new ApplicationUser
                {
                    CPF = usuario.CPF,
                    Nome = usuario.Nome,
                    UserName = usuario.Email,
                    Matricula = usuario.Matricula,
                    Email = usuario.Email,
                };
                IdentityResult adicionarDadosPessoais = await _userManager.CreateAsync(dadosUsuario, usuario.Senha);

                string[] listaCursosIds = usuario.Curso;
                UsuarioNoCurso[] listaUsuariosNoCurso = MontarUsuariosNoCurso(listaCursosIds , dadosUsuario.Id);
                new UsuarioNoCursoRepository(_db).AdicionarLista(listaUsuariosNoCurso); 

                if (adicionarDadosPessoais.Succeeded)
                {
                    _logger.LogInformation("Criada uma nova conta com senha.");

                    //TODO resolver e-mail
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(dadosUsuario);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = dadosUsuario.Id, code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(usuario.Email, "Banco de Itens SENAI | Confirmação de e-mail",
                        $"Por favor, confirme a sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicando aqui</a>.");

                    //await _signInManager.SignInAsync(dadosUsuario, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in adicionarDadosPessoais.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private UsuarioNoCurso[] MontarUsuariosNoCurso(string[] listaCursosIds, string usuarioId)
        {
            List<UsuarioNoCurso> listaUsuarioNosCursos = new List<UsuarioNoCurso>();

            foreach (var cursoIdString in listaCursosIds)
            {
                if (Int32.TryParse(cursoIdString, out var cursoIdInt))
                {
                    UsuarioNoCurso usuarioNoCurso = new UsuarioNoCurso
                    {
                        UsuarioId = usuarioId,
                        CursoId = cursoIdInt,
                    };

                    listaUsuarioNosCursos.Add(usuarioNoCurso);
                }
            }

            return listaUsuarioNosCursos.ToArray();
        }
    }
}
