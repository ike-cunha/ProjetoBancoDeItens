using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoDeItens.Data.DTO
{
    public class RegistroDTO
    {
        [Required]
        [StringLength(15, ErrorMessage = "Insira um CPF válido, somente números.")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(120, ErrorMessage = "Por favor, insira um nome válido.", MinimumLength = 3)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Insira uma matrícula válida, somente números.")]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Escolha ao menos um curso")]
        [Display(Name = "Curso(s)")]
        public IdNomeDTO[] Curso { get; set; }

        [Required(ErrorMessage = "Escolha ao menos uma unidade curricular")]
        [Display(Name = "Unidade(s) Curricular(es)")]
        public IdNomeDTO[] UnidadeCurricular { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "A senha deve ter entre {2} e {1} caractéres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Senha", ErrorMessage = "As senhas não são iguais.")]
        public string ConfirmaASenha { get; set; }

    }
}
