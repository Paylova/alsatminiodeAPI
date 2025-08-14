using alsatminiode.Application.Features.Commands.Customer;
using alsatminiode.Application.Features.Commands.Customer.DeleteCustomer;
using alsatminiode.Application.Features.Commands.Customer.UpdateCustomer;
using alsatminiode.Application.Features.Queries.Customer.GetAllCustomer;
using alsatminiode.Application.Features.Queries.Customer.GetByIdCustomer;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Get([FromQuery] GetAllCustomerQueryRequest getAllCustomerQueryRequest)
        {
            GetAllCustomerQueryResponse response = await _mediator.Send(getAllCustomerQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCustomerQueryRequest getByIdCustomerQueryRequest)
        {
            GetByIdCustomerQueryResponse response = await _mediator.Send(getByIdCustomerQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerCommandRequest createCustomerCommandRequest)
        {
            CreateCustomerReqeustResponse response = await _mediator.Send(createCustomerCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCustomerCommandRequest deleteCustomerCommandRequest)
        {
            DeleteCustomerCommandResponse response = await _mediator.Send(deleteCustomerCommandRequest);
            return Ok();
        }
        [HttpPut]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Put([FromBody] UpdateCustomerCommandRequest updateCustomerCommandRequest)
        {
            UpdateCustomerCommandResponse response = await _mediator.Send(updateCustomerCommandRequest);
            return Ok();
        }
    }
}
