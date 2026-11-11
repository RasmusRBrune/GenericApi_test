using System.Linq.Expressions;

namespace GenericApi.Interface
{
    public interface IBaseRepository<T>
    {

        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> AddAsync(T entity);
        Task<bool> SaveChangesAsync();
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);

    }
}
