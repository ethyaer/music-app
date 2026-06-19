using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Application.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(object id);
        Task<TEntity?> GetByIdAsync(params object[] keys);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(object id);
    }
}
