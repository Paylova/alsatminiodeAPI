using alsatminiode.Application.Features.Commands.City.CreateCity;
using alsatminiode.Application.Features.Commands.City.UpdateCity;
using alsatminiode.Application.Features.Queries.City.GetAllCity;
using alsatminiode.Application.Features.Queries.City.GetByIdCity;
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
    public class CityController : ControllerBase
    {
        readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCityQueryRequest getAllCityQueryRequest)
        {
            GetAllCityQueryResponse response = await _mediator.Send(getAllCityQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCityQueryRequest getByIdCityQueryRequest)
        {
            GetByIdCityQueryResponse response = await _mediator.Send(getByIdCityQueryRequest);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCityCommandRequest createCityCommandRequest)
        {
            CreateCityCommandResponse response = await _mediator.Send(createCityCommandRequest);
            return Ok((int)HttpStatusCode.Created);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCityCommandRequest updateCityCommandRequest)
        {
            UpdateCityCommandResponse response = await _mediator.Send(updateCityCommandRequest);
            return Ok();
        }



    }
}
