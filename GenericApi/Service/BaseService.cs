using GenericApi.Entity;
using GenericApi.Interface;
using System.Linq.Expressions;

namespace GenericApi.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> BaseRepo)
        {
                _baseRepository = BaseRepo;
        }
        public async Task<bool> Create(T item)
        {
            return await _baseRepository.AddAsync(item);
            //var data = await _baseRepository.AddAsync(item);
            //if (data)
            //{
            //    return true;
            //}
            //return false;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate)
        {
            return await _baseRepository.FindByConditionAsync(predicate);
        }

        public async Task<List<T>> Getall()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public async Task<T> Update(T item)
        {
            //var data = await _baseRepository.SaveChangesAsync(item);
            throw new NotImplementedException();
        }
    }
}

