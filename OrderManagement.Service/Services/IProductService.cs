using OrderManagement.Repository.Model;

namespace OrderManagement.Service.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int productId);
        void CreateProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
    }
}
