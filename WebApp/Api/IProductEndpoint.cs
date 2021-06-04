using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAllProducts();
        Task<ProductModel> GetProduct(int id);
        Task PostProduct(ProductModel product);
    }
}