using OrderManagement.Repository.Model;

namespace OrderManagement.Service.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrder(int orderId);
        void CreateOrder(Order order);
        void DeleteOrder(int orderId);
        void UpdateOrder(Order order);
    }
}
