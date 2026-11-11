using GenericApi.Entity;
using GenericApi.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GenericApi.Repo
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly DBEntity _context;
        private readonly DbSet<T> _entities;
        private readonly T _entitie;

        public BaseRepository(DBEntity context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task<bool> AddAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.SingleOrDefaultAsync(I => I.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false) > 0;
        }
    }
}
