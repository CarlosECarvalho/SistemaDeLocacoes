using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeLocacoes.Entidades;

namespace SistemaDeLocacoes.Repositorio.Contratos
{
    public interface IEnderecoEmpresaRepository
    {
        void Adicionar(EnderecoEmpresa enderecoEmpresa);
        void Atualizar(EnderecoEmpresa enderecoEmpresa);
        EnderecoEmpresa Get(int id);
        List<EnderecoEmpresa> Get();
    }
}
