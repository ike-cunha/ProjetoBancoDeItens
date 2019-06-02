using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoBancoDeItens.Data.Model;

namespace ProjetoBancoDeItens.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<UsuarioNoCurso> UsuarioNoCurso { get; set; }
        public DbSet<UnidadeCurricular> UnidadeCurricular { get; set; }
        public DbSet<UnidadeCurricularNoCurso> UnidadeCurricularNoCurso { get; set; }
        public DbSet<UsuarioNaUnidadeCurricular> UsuarioNaUnidadeCurricular { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<CompetenciaDoItem> CompetenciaDoItem { get; set; }
    }
}
