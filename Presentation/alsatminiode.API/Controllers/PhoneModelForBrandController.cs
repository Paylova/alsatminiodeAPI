using alsatminiode.Application.Features.Queries.PhoneModel.PhoneModelForBrand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneModelForBrandController : ControllerBase
    {
        IMediator _mediator;

        public PhoneModelForBrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] PhoneModelForBrandQueryRequest modelForBrandQueryRequest)
        {
            PhoneModelForBrandQueryResponse response = await _mediator.Send(modelForBrandQueryRequest);
            return Ok(response);
        }

    }
}
