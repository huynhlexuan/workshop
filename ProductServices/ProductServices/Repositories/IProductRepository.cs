using ProductServices.Models;
using System.Threading.Tasks;

namespace ProductServices.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<bool> CreateProductAsync(Product product);
    }
}
