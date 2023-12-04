using OrderManagement.Repository.Model;

namespace OrderManagement.Service.Services
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetail(int orderDetailId);
        void CreateOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
    }
}
