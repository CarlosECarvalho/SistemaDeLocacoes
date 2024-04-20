using SistemaDeLocacoes.Entidades;

namespace SistemaDeLocacoes.Repositorio.Contratos
{
    public interface IEmpresaRepository
    {
        Task AddAsync(Empresa empresa);

    }
}
