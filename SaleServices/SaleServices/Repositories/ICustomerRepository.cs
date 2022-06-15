using CustomerServices.Models;
using System.Threading.Tasks;

namespace CustomerServices.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerById(int id);
    }
}
