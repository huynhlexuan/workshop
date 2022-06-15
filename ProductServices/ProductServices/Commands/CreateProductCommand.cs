using MediatR;
using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Commands
{
    public class CreateProductCommand : IRequest<bool>
    {
        public Product DTO { get; set; }
    }
}
