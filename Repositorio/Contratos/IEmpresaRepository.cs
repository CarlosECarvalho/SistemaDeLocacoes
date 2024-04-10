using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeLocacoes.Entidades;

namespace SistemaDeLocacoes.Repositorio.Contratos
{
    public interface IEmpresaRepository
    {
        void Adicionar(Empresa empresa);
        void Atualizar(Empresa empresa);
        Empresa Get(int id);
        List<Empresa> Get();
    }
}
