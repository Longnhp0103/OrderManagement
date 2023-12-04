using OrderManagement.Repository.Model;
using OrderManagement.Repository.Repositories;

namespace OrderManagement.Service.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository ProductRepository;
        ProductService(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
        public void CreateProduct(Product product)
        {
            ProductRepository.Insert(product);
        }

        public void DeleteProduct(int productId)
        {
            ProductRepository.Delete(productId);
        }

        public Product GetProduct(int productId)
        {
            return ProductRepository.GetById(productId);
        }

        public List<Product> GetProducts()
        {
            return (List<Product>)ProductRepository.GetAll();
        }

        public void UpdateProduct(Product product)
        {
            ProductRepository.Update(product);
        }


    }
}
