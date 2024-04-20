using SistemaDeLocacoes.Entidades;
using SistemaDeLocacoes.Repositorio.Contratos;

namespace SistemaDeLocacoes.Repositorio
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly IRepositoryBase<Empresa> _repositoryBase;
        public EmpresaRepository(IRepositoryBase<Empresa> repositoryBase) => _repositoryBase = repositoryBase;

        public async Task AddAsync(Empresa empresa)
        {
            await _repositoryBase.AddAsync(empresa);
        }
    }
}

