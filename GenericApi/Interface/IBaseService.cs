using System.Linq.Expressions;

namespace GenericApi.Interface
{
    public interface IBaseService<T>
    {
        Task<List<T>> Getall();

        Task<T> GetById(int id);

        Task<T> Update(T item);

        Task<bool> Create(T item);

        Task<bool> Delete(int id);

        Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);
    }
}
