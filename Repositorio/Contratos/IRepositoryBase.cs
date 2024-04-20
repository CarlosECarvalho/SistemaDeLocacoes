using System.Linq.Expressions;

namespace SistemaDeLocacoes.Repositorio.Contratos
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> ObterPorIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task DeletarAsync(TEntity entity);
        Task Atualizar(TEntity entity);
    }
}
