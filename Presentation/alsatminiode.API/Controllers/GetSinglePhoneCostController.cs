using alsatminiode.Application.Features.Queries.PhoneCost.GetBySinglePhoneCost;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetSinglePhoneCostController : ControllerBase
    {
        IMediator _mediator;

        public GetSinglePhoneCostController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetBySinglePhoneCostQueryRequest getBySinglePhoneCostQueryRequest)
        {
            GetBySinglePhoneCostQueryResponse response = await _mediator.Send(getBySinglePhoneCostQueryRequest);
            return Ok(response);
        }
    }
}
