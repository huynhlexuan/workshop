using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductServices.Commands;
using ProductServices.Models;
using ProductServices.Queries;
using System;
using System.Threading.Tasks;

namespace ProductServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetProductDetailQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand command)
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
            await _mediator.Send(new DeleteProductCommand { Id = id });

            return NoContent();
        }
    }
}
