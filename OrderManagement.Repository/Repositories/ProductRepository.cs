using OrderManagement.Repository.Model;

namespace OrderManagement.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Assignment1Context dbContext) : base(dbContext)
        {
        }
    }
}
