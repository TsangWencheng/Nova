using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    public interface IDataWarehouse
    {
        Task SaveAsync<T>(T entity);

        Task DeleteAsync<T>(T entity);

        Task<IQueryable> QueryAsync<T>();
    }
}