using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    /// <summary>
    ///     Provides a set of operations working with entities of specific type.
    /// </summary>
    /// <typeparam name="T">The type of the entities.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        ///     Save the entity.
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <returns>A <see cref="Task" /> representing the asynchronous save operation.</returns>
        /// <remarks>The entity will be updated if already exists.</remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entity" /> is null.</exception>
        Task SaveAsync(T entity);

        /// <summary>
        ///     Save a series of entities.
        /// </summary>
        /// <param name="entities">A <see cref="IEnumerable{T}" /> containing the series of entities.</param>
        /// <returns>A <see cref="Task" /> representing the asynchronous save operation.</returns>
        /// <remarks>
        ///     The entities will be updated if already exists.
        ///     Do nothing if <paramref name="entities" /> is an empty collection.
        /// </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entities" /> is null.</exception>
        /// <exception cref="ArgumentException">Any element of <paramref name="entities" /> is null.</exception>
        Task SaveAllAsync(IEnumerable<T> entities);

        /// <summary>
        ///     Delete the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>A <see cref="Task" /> that represents the asynchronous delete operation.</returns>
        /// <remarks>Nothing will be done if the entity is not exists.</remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entity" /> is null.</exception>
        Task DeleteAsync(T entity);

        /// <summary>
        ///     Delete a series of entities.
        /// </summary>
        /// <param name="entities">A <see cref="IEnumerable{T}" /> containing the series of entities.</param>
        /// <returns>A <see cref="Task" /> representing the asynchronous delete operation.</returns>
        /// <remarks>
        ///     Ignore which in <paramref name="entities" /> is not exists.
        ///     Do nothing if <paramref name="entities" /> is an empty collection.
        /// </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entities" /> is null.</exception>
        /// <exception cref="ArgumentException">Any element of <paramref name="entities" /> is null.</exception>
        Task DeleteAllAsync(IEnumerable<T> entities);

        /// <summary>
        ///     Get a <see cref="IQueryable{T}" /> of all entities of a specific type.
        /// </summary>
        /// <returns>
        ///     A <see cref="Task" /> that represents the asynchronous save operation.
        ///     The task result contains a <see cref="IQueryable{T}" /> of all entities of type <typeparamref name="T" />
        /// </returns>
        /// <remarks>An empty collection will be returned if no entities found.</remarks>
        Task<IQueryable<T>> QueryAsync();
    }
}