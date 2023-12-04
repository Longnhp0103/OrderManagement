using OrderManagement.Repository.Model;
using OrderManagement.Repository.Repositories;

namespace OrderManagement.Service.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository OrderRepository;
        OrderService(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }
        public void CreateOrder(Order order)
        {
            OrderRepository.Insert(order);
        }

        public void DeleteOrder(int orderId)
        {
            OrderRepository?.Delete(orderId);
        }

        public Order GetOrder(int orderId)
        {
            return OrderRepository.GetById(orderId);
        }

        public List<Order> GetOrders()
        {
            return (List<Order>)OrderRepository.GetAll();
        }

        public void UpdateOrder(Order order)
        {
            OrderRepository.Update(order);
        }
    }
}
