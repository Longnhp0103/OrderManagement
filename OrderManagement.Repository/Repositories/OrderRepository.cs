using OrderManagement.Repository.Model;

namespace OrderManagement.Repository.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(Assignment1Context dbContext) : base(dbContext)
        {
        }
    }
}
