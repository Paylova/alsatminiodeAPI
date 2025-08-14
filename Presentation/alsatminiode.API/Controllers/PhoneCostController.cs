using alsatminiode.Application.Features.Commands.PhoneCost.UpdateCost;
using alsatminiode.Application.Features.Queries.PhoneCost;
using alsatminiode.Application.Features.Queries.PhoneCost.GetBySinglePhoneCost;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Admin")]
    public class PhoneCostController : ControllerBase
    {
        IMediator  _mediator;

        public PhoneCostController(IMediator mediator)
        {
            _mediator = mediator;
        }

       [HttpGet("{id}")]
       public async Task<IActionResult> Get([FromRoute] GetByIdPhoneCostQueryRequest getByIdPhoneCostQueryRequest)
        {
            GetByIdPhoneCostQueryResponse response = await _mediator.Send(getByIdPhoneCostQueryRequest);
            return Ok(response);
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePhoneCostCommandRequest updatePhoneCostCommandRequest)
        {
            UpdatePhoneCostCommandResponse response = await _mediator.Send(updatePhoneCostCommandRequest);
            return Ok();
        }
    }
}
