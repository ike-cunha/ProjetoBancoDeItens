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

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

                
        //    builder.Entity<ApplicationUser>(entity =>
        //    {
        //        //entity.ToTable("Usuario");
        //        //entity.Property(u => u.UserName).HasColumnName("Email");
        //        //entity.Ignore(e => e.Email);
        //        entity.Ignore(n => n.NormalizedUserName);
        //        entity.Ignore(n => n.NormalizedEmail);
        //    });
        //}

        public DbSet<Curso> Curso { get; set; }
        public DbSet<UsuarioNoCurso> UsuarioNoCurso { get; set; }
        public DbSet<UnidadeCurricular> UnidadeCurricular { get; set; }
        public DbSet<UnidadeCurricularNoCurso> UnidadeCurricularNoCurso { get; set; }
        public DbSet<UsuarioNaUnidadeCurricular> UsuarioNaUnidadeCurricular { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<CompetenciaDoItem> CompetenciaDoItem { get; set; }
        public DbSet<ConteudoItem> ConteudoItem { get; set; }
        public DbSet<HistoricoConteudoItem> HistoricoConteudoItem { get; set; }
        public DbSet<AlternativaItem> AlternativaItem  { get; set; }
    }
}
