using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Repositories
{
    /// <summary>
    /// Generic repository implementing common CRUD operations for entities.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext context) 
        {
            this.context = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Retrieves all entities of type <typeparamref name="TEntity"/>.
        /// </summary>
        /// <returns>All entities.</returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(object id) 
        {
             return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity?> GetByIdAsync(params object[] keys)
        {
            return await _dbSet.FindAsync(keys);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity) 
        {
            _dbSet.Update(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes an entity by primary key if it exists.
        /// </summary>
        /// <param name="id">Primary key value of the entity to delete.</param>
        public async Task DeleteAsync(object id) 
        {
            var ent = await _dbSet.FindAsync(id);

            if(ent != null) 
            { 
                _dbSet.Remove(ent);
                await context.SaveChangesAsync();
            }
        }
    }
}
