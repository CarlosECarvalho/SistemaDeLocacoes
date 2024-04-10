using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacoes.Entidades.Configuracao
{
    public class ConfiguracaoEmpresa : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TipoPessoa).HasMaxLength(1).IsRequired();
            builder.Property(x => x.CPF_CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(x => x.RazaoSocial).HasMaxLength(120).IsRequired();
            builder.Property(x => x.NomeFantasia).HasMaxLength(120);
            builder.Property(x => x.Categoria).HasMaxLength(100).IsRequired();
            builder.HasMany(x => x.EnderecoEmpresa).WithOne(x => x.Empresa).HasForeignKey(x => x.EmpresaId);
        }
    }
}
