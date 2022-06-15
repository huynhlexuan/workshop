using MediatR;
using CustomerServices.Models;

namespace CustomerServices.Queries
{
    public class GetCustomerQuery : IRequest<Customer>
    {
        public int Id { get; set; }
    }
}
