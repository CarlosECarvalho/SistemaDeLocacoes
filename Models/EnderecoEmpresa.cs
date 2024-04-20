using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacoes.Entidades
{
    public class EnderecoEmpresa
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public string Descricao { get; set;}
        public string Situacao { get; set;}
        public bool? ClienteSN { get; set;}
        public bool? FornecedorSN { get; set;}
        public bool? TransportadoraSN { get; set;}
        public string? Contato1 { get; set;}
        public string? Contato2 { get; set;}
        public string? Email { get; set;}
        public string? PessoaRecado { get; set;}
        public DateTimeOffset Alteracao { get; set;}
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        
    }
}
