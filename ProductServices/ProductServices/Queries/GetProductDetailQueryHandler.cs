using MediatR;
using ProductServices.Models;
using ProductServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductServices.Queries
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, Product>
    {
        private readonly IProductRepository _productRepository;
        public GetProductDetailQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {

            return await _productRepository.GetProductByIdAsync(request.Id);
        }
    }
}
