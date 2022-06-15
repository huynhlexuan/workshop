using MediatR;
using CustomerServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServices.Commands
{
    public class UpdateCustomerCommand : IRequest<bool>
    {
        public Customer DTO { get; set; }
    }
}
