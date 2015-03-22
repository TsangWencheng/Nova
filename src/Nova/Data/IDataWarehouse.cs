using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    /// <summary>
    ///     Provides a set of operations to save, delete and query entities.
    /// </summary>
    public interface IDataWarehouse
    {
        /// <summary>
        ///     Save the entity.
        /// </summary>
        /// <typeparam name="T">The type of the entity.</typeparam>
        /// <param name="entity">The entity</param>
        /// <returns>A <see cref="Task" /> representing the asynchronous save operation.</returns>
        /// <remarks>The entity will be updated if already exists.</remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entity" /> is null.</exception>
        Task SaveAsync<T>(T entity);

        /// <summary>
        ///     Delete the entity.
        /// </summary>
        /// <typeparam name="T">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns>A <see cref="Task" /> that represents the asynchronous delete operation.</returns>
        /// <remarks>Nothing will be done if the entity is not exists.</remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entity" /> is null.</exception>
        Task DeleteAsync<T>(T entity);

        /// <summary>
        ///     Get a <see cref="IQueryable{T}" /> of all entities of a specific type.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <returns>
        ///     A <see cref="Task" /> that represents the asynchronous save operation.
        ///     The task result contains a <see cref="IQueryable{T}" /> of all entities of type <typeparamref name="T" />
        /// </returns>
        /// <remarks>An empty collection will be returned if no entities found.</remarks>
        Task<IQueryable<T>> QueryAsync<T>();
    }
}