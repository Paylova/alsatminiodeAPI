using alsatminiode.Application.Features.Commands.Country.CreateCountry;
using alsatminiode.Application.Features.Commands.Country.RemoveCountry;
using alsatminiode.Application.Features.Commands.Country.UpdateCountry;
using alsatminiode.Application.Features.Queries.Country.GetAllCountry;
using alsatminiode.Application.Features.Queries.Country.GetByIdCountry;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Admin")]
    public class CountryController : ControllerBase
    {
        readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCountryQueryRequest getAllCountryQueryRequest)
        {
            GetAllCountryQueryResponse response = await _mediator.Send(getAllCountryQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCountryQueryRequest getByIdCountryQueryRequest)
        {
            GetByIdCountryQueryResponse response = await _mediator.Send(getByIdCountryQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCountryCommandRequest createCountryCommandRequest)
        {
            CreateCountryCommandResponse response = await _mediator.Send(createCountryCommandRequest);
            return Ok((int)HttpStatusCode.Created);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCountryCommandRequest removeCountryCommandRequest)
        {
            RemoveCountryCommandResponse response = await _mediator.Send(removeCountryCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCountryCommandRequest updateCountryCommandRequest)
        {
            UpdateCountryCommandResponse response = await _mediator.Send(updateCountryCommandRequest);
            return Ok();
        }
    }
}
