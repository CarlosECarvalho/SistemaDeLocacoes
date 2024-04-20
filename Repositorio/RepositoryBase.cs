using Microsoft.EntityFrameworkCore;
using SistemaDeLocacoes.Database;
using SistemaDeLocacoes.Repositorio.Contratos;
using System.Linq.Expressions;

namespace SistemaDeLocacoes.Repositorio
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public readonly DatabaseContext _context;
        public readonly DbSet<TEntity> _DbSet;
        private bool disposedValue;

        public RepositoryBase(DatabaseContext context)
        {
            _context = context;
            _DbSet = context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _DbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(TEntity entity)
        {
            _DbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarAsync(TEntity entity)
        {
            _DbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _DbSet.AsQueryable();
            if (filter != null)
            {
                query = query
                    .Where(filter)
                    .AsNoTracking();
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> ObterPorIdAsync(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RepositoryBase()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
