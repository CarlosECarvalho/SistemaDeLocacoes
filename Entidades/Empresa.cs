using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacoes.Entidades
{
    public class Empresa
    {
        public int Id { get; set; }
        public char TipoPessoa { get; set; }
        public string CPF_CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string Categoria { get; set; }
        public EnderecoEmpresa Endereco { get; set; }
        public ICollection<EnderecoEmpresa> EnderecoEmpresa { get; set; }

    }
}
