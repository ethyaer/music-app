namespace API.Infrastructure.Repositories
{
    /// <summary>
    /// Generic repository interface declaring common CRUD operations for entities.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Retrieves all entities of type <typeparamref name="TEntity"/>.
        /// </summary>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Finds an entity by a single primary key.
        /// </summary>
        /// <param name="id">Primary key value.</param>
        Task<TEntity?> GetByIdAsync(object id);

        /// <summary>
        /// Finds an entity by composite primary keys.
        /// </summary>
        /// <param name="keys">Primary key values.</param>
        Task<TEntity?> GetByIdAsync(params object[] keys);

        /// <summary>
        /// Adds a new entity to the data set.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Updates an existing entity and persists changes.
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Deletes an entity by its primary key if found.
        /// </summary>
        /// <param name="id">Primary key value.</param>
        Task DeleteAsync(object id);
    }
}
