using alsatminiode.Application.Features.Commands.District.CreateDistrict;
using alsatminiode.Application.Features.Queries.District.GetAllDistrict;
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
    public class DistrictController : ControllerBase
    {
        readonly IMediator _mediator;

        public DistrictController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllDistrictQueryRequest getAllDistrictQueryRequest)
        {
            GetAllDistrictQueryResponse response = await _mediator.Send(getAllDistrictQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDistrictCommandRequest createDistrictCommandRequest)
        {
            CreateDistrictCommandResponse response = await _mediator.Send(createDistrictCommandRequest);
            return Ok((int)HttpStatusCode.Created);
        } 
    }
}
