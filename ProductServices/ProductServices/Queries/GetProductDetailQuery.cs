using MediatR;
using ProductServices.Models;

namespace ProductServices.Queries
{
    public class GetProductDetailQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
