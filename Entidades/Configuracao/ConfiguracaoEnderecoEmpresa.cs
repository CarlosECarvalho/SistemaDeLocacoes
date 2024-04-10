using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacoes.Entidades.Configuracao
{
    internal class ConfiguracaoEnderecoEmpresa : IEntityTypeConfiguration<EnderecoEmpresa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EnderecoEmpresa> builder)
        {
            builder.ToTable("EnderecosEmpresas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CEP).HasMaxLength(8).IsRequired();
            builder.Property(x => x.Endereco).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Numero).HasMaxLength(6).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(x => x.UF).HasMaxLength(2).IsRequired();
            builder.Property(x => x.Pais).HasMaxLength(50).IsRequired().HasDefaultValue("Brasil");
            builder.Property(x => x.Descricao).HasMaxLength(100);
            builder.Property(x => x.Situacao).HasMaxLength(1).HasDefaultValue('A');
            builder.Property(x => x.ClienteSN);
            builder.Property(x => x.FornecedorSN);
            builder.Property(x => x.TransportadoraSN);
            builder.Property(x => x.Contato1).HasMaxLength(7);
            builder.Property(x => x.Contato2).HasMaxLength(7);
            builder.Property(x => x.Email).HasMaxLength(80);
            builder.Property(x => x.PessoaRecado).HasMaxLength(30);
            builder.Property(x => x.Alteracao).IsRequired();
            builder.HasOne(x => x.Empresa).WithMany(x => x.EnderecoEmpresa).HasForeignKey(x => x.EmpresaId);
        }
    }
}
