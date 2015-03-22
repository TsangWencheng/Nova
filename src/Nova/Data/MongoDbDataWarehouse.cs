using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    /// <summary>
    ///     Provides a set of operations to save, delete and query entities with MongoDb.
    /// </summary>
    /// <remarks>
    ///     Collection name in MongoDb should the same as the type name,
    ///     for example, <c>User</c> should be stored in "User" collection.
    /// </remarks>
    public class MongoDbDataWarehouse : IDataWarehouse
    {
        /// <summary>
        ///     Initialize a new instance of <see cref="MongoDbDataWarehouse" />.
        /// </summary>
        /// <remarks>
        ///     Server address and database name should be loaded form project configuration file:
        ///     Server address: "Data:MongoDb:Server, Database name: "Data:MongoDb:DataBase".
        /// </remarks>
        public MongoDbDataWarehouse()
        {
        }

        /// <summary>
        ///     Initialize a new instance of <see cref="MongoDbDataWarehouse" />.
        /// </summary>
        /// <param name="serverAddress">The server address.</param>
        /// <param name="databaseName">The name of the database.</param>
        /// <remarks>
        ///     <paramref name="serverAddress" /> and <paramref name="databaseName" /> should be loaded from configuration file if
        ///     it is null.
        /// </remarks>
        public MongoDbDataWarehouse(string serverAddress = null, string databaseName = null)
        {
        }

        /// <summary>
        ///     Save the entity to MongoDb.
        /// </summary>
        /// <typeparam name="T">The type of the entity.</typeparam>
        /// <param name="entity">The entity</param>
        /// <returns>A <see cref="Task" /> representing the asynchronous save operation.</returns>
        /// <remarks>The entity will be updated if already exists.</remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entity" /> is null.</exception>
        public Task SaveAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Delete the entity.
        /// </summary>
        /// <typeparam name="T">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns>A <see cref="Task" /> that represents the asynchronous delete operation.</returns>
        /// <remarks>Nothing will be done if the entity is not exists.</remarks>
        /// <exception cref="ArgumentNullException"><paramref name="entity" /> is null.</exception>
        public Task DeleteAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Get a <see cref="IQueryable{T}" /> of all entities of a specific type.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <returns>
        ///     A <see cref="Task" /> that represents the asynchronous save operation.
        ///     The task result contains a <see cref="IQueryable{T}" /> of all entities of type <typeparamref name="T" />
        /// </returns>
        /// <remarks>An empty collection will be returned if no entities found.</remarks>
        public Task<IQueryable<T>> QueryAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}