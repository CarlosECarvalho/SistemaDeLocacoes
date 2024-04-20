using SistemaDeLocacoes.Entidades;

namespace SistemaDeLocacoes.Repositorio.Contratos
{
    public interface IEnderecoEmpresaRepository
    {
        Task AddAsync(EnderecoEmpresa enderecoEmpresa);

    }
}
