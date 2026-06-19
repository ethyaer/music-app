using API.Application.Interfaces;
using API.Infrastructure.Repositories;

namespace API.Application.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> repository;

        public Service(IGenericRepository<TEntity> repository) => this.repository = repository;
        public Task<IEnumerable<TEntity>> GetAllAsync() => repository.GetAllAsync();
        public Task<TEntity?> GetByIdAsync(object id) => repository.GetByIdAsync(id);
        public Task<TEntity?> GetByIdAsync(params object[] keys) => repository.GetByIdAsync(keys);
        public Task AddAsync(TEntity entity) => repository.AddAsync(entity);
        public Task UpdateAsync(TEntity entity) => repository.UpdateAsync(entity);
        public Task DeleteAsync(object id) => repository.DeleteAsync(id);
    }
}
