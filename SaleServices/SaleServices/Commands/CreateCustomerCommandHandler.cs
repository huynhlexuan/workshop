using MediatR;
using CustomerServices.Models;
using CustomerServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerServices.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository;
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return false;
        }
    }
}
