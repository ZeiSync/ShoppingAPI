using shoppingAPI.Data.Entity;
using System.Threading.Tasks;

namespace shoppingAPI.Data.Repository
{
    public interface IProductRepository
    {
        //general
        void Add<T>(T entity) where T : class;

        void Delete<T>(T endtity) where T : class;

        Task<bool> SaveChangesAsync();

        //get Product Table
        Task<Product[]> GetAllProductAsync(bool includeSpecification = false);

        Task<Product> GetProductAsync(string productName, bool includeSpecification = false);
    }
}