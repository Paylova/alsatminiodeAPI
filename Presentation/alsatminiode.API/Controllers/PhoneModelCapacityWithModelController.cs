using alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetByIdPhoneModelCapacityWithPhoneModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneModelCapacityWithModelController : ControllerBase
    {
        readonly IMediator _mediator;

        public PhoneModelCapacityWithModelController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdPhoneModelCapacityWithPhoneModelRequest getByIdPhoneModelCapacityWithPhoneModelRequest)
        {
            GetByIdPhoneModelCapacityWithPhoneModelResponse response = await _mediator.Send(getByIdPhoneModelCapacityWithPhoneModelRequest);
            return Ok(response);
        }
    }
}
