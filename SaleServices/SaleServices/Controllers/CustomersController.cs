using MediatR;
using Microsoft.AspNetCore.Mvc;
using CustomerServices.Commands;
using CustomerServices.Queries;
using System;
using System.Threading.Tasks;

namespace CustomerServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController: Controller
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetCustomerQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomerCommand command)
        {
            if (command == null)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCustomerCommand { Id = id });

            return NoContent();
        }
    }
}
