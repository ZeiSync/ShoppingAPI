using Microsoft.EntityFrameworkCore;
using shoppingAPI.Data.Context;
using shoppingAPI.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingAPI.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _appDbContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _appDbContext.Remove(entity);
        }

        public async Task<Product[]> GetAllProductAsync(bool includeSpecification = false)
        {
            IQueryable<Product> query = _appDbContext.Products
            .Include(x => x.Quantity)

            .Include(x => x.Branch)
            .ThenInclude(x => x.Category)

            .Include(x => x.Brand)
            .Include(x => x.ProductDescription);
            if (includeSpecification)
            {
                query = query.Include(x => x.Specification).ThenInclude(x => x.GrandPiano);
                query = query.Include(x => x.Specification).ThenInclude(x => x.UprightPiano);
                query = query.Include(x => x.Specification).ThenInclude(x => x.DigitalPiano);
            }
            return await query.ToArrayAsync();
        }

        public async Task<Product> GetProductAsync(string productName, bool includeSpecification = false)
        {
            IQueryable<Product> query = _appDbContext.Products
            .Include(x => x.Quantity)
            .Include(x => x.Branch)
            .ThenInclude(x => x.Category)
            .Include(x => x.Brand)
            .Include(x => x.ProductDescription);

            if (includeSpecification)
            {
                query = query.Include(x => x.Specification).ThenInclude(x => x.GrandPiano);
                query = query.Include(x => x.Specification).ThenInclude(x => x.UprightPiano);
                query = query.Include(x => x.Specification).ThenInclude(x => x.DigitalPiano);
            }
            query = query.Where(c => c.ProductName == productName);

            return await query.FirstOrDefaultAsync();
             
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _appDbContext.SaveChangesAsync()) > 0;
        }
    }
}