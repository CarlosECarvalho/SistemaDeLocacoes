using Microsoft.EntityFrameworkCore;
using SistemaDeLocacoes.Entidades.Configuracao;
using System;
//using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacoes.Database
{
    public class SistemaContext : DbContext
    {
       

        public DbSet<Entidades.Empresa> Empresas { get; set; }
        public DbSet<Entidades.EnderecoEmpresa> EnderecosEmpresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PC-CADU\\SQLEXPRESS;Database=BancoSistema;Integrated Security=SSPI;TrustServerCertificate=True; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfiguracaoEmpresa());
            modelBuilder.ApplyConfiguration(new ConfiguracaoEnderecoEmpresa());
        }
    }
}
