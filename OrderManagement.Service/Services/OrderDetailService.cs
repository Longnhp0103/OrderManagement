using OrderManagement.Repository.Model;
using OrderManagement.Repository.Repositories;

namespace OrderManagement.Service.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailRepository OrderDetailRepository;
        OrderDetailService(OrderDetailRepository orderDetailRepository)
        {
            this.OrderDetailRepository = orderDetailRepository;
        }
        public void CreateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailRepository.Insert(orderDetail);
        }

        public OrderDetail GetOrderDetail(int orderDetailId)
        {
            return OrderDetailRepository.GetById(orderDetailId);
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return (List<OrderDetail>)OrderDetailRepository.GetAll();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailRepository.Update(orderDetail);
        }
    }
}
