using alsatminiode.Application.Features.Commands.PhoneModelCapacity.CreatePhoneModelCapacity;
using alsatminiode.Application.Features.Commands.PhoneModelCapacity.RemovePhoneModelCapacity;
using alsatminiode.Application.Features.Commands.PhoneModelCapacity.UpdatePhoneModelCapacity;
using alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetAllPhoneModelCapacity;
using alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetByIdPhoneModelCapacity;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneModelCapacityController : ControllerBase
    {
        readonly IMediator _mediator;

        public PhoneModelCapacityController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPhoneModelCapacityQueryRequest getAllPhoneModelCapacityQueryRequest)
        {
            GetAllPhoneModelCapacityQueryResponse response = await _mediator.Send(getAllPhoneModelCapacityQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdPhoneModelCapacityQueryRequest getByIdPhoneModelCapacityQueryRequest)
        {
            GetByIdPhoneModelCapacityQueryResponse response = await _mediator.Send(getByIdPhoneModelCapacityQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePhoneModelCapacityCommandRequest createPhoneModelCapacityCommandRequest)
        {
            CreatePhoneModelCapacityCommandResponse response = await _mediator.Send(createPhoneModelCapacityCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePhoneModelCapacityCommandRequest updatePhoneModelCapacityCommandRequest)
        {
            UpdatePhoneModelCapacityCommandResponse response = await _mediator.Send(updatePhoneModelCapacityCommandRequest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemovePhoneModelCapacityCommandRequest removePhoneModelCapacityCommandRequest)
        {
            RemovePhoneModelCapacityCommandResponse response = await _mediator.Send(removePhoneModelCapacityCommandRequest);
            return Ok();
        }
    }
}
