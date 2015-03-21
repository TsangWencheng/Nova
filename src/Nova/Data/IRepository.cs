using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    public interface IRepository<T>
    {
        Task SaveAsync(T entity);

        Task SaveAllAsync(IEnumerable<T> entities);

        Task DeleteAsync(T entity);

        Task DeleteAllAsync(IEnumerable<T> entity);

        Task<IQueryable> QueryAsync();
    }
}