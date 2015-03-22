using System.Linq;
using System.Threading.Tasks;

namespace Nova.Data
{
    public class MongoDbDataWarehouse :IDataWarehouse
    {
        public Task SaveAsync<T>(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync<T>(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IQueryable<T>> QueryAsync<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}