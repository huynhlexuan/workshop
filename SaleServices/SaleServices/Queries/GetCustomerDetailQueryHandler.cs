using MediatR;
using CustomerServices.Models;
using CustomerServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerServices.Queries
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {

            return await _customerRepository.GetCustomerById(request.Id);
        }
    }
}
