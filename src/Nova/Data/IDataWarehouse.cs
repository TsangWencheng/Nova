using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    public interface IDataWarehouse
    {
        Task SaveAsync<T, TId>(T entity) where T : IEntity<TId>;

        Task DeleteAsync<T, TId>(T entity) where T : IEntity<TId>;

        Task<IQueryable> QueryAsync<T, TId>() where T : IEntity<TId>;
    }
}