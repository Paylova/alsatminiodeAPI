using alsatminiode.Application.Features.Commands.Admin.CreateAdmin;
using alsatminiode.Application.Features.Commands.Admin.RemoveAdmin;
using alsatminiode.Application.Features.Commands.Admin.UpdateAdmin;
using alsatminiode.Application.Features.Queries.Admin.GetAllAdmin;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class AdminController : ControllerBase
    {
        readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllAdminQueryRequest getAllAdminQueryRequest)
        {
            GetAllAdminQueryResponse response = await _mediator.Send(getAllAdminQueryRequest);
            return Ok(response);

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAdminCommandRequest createAdminCommandRequest )
        {
            CreateAdminCommandResponse response = await _mediator.Send(createAdminCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAdminCommandRequest removeAdminCommandRequest)
        {
            RemoveAdminCommandResponse response = await _mediator.Send(removeAdminCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UpdateAdminCommandRequest updateAdminCommandRequest)
        {
            UpdateAdminCommandResponse response = await _mediator.Send(updateAdminCommandRequest);
            return Ok();
        }

    }
}
