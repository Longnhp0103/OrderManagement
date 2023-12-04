using OrderManagement.Repository.Model;

namespace OrderManagement.Repository.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(Assignment1Context dbContext) : base(dbContext)
        {
        }
    }
}
