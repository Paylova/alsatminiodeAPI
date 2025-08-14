using alsatminiode.Application.Features.Commands.WebsiteOption.UpdateWebsiteOption;
using alsatminiode.Application.Features.Queries.WebsiteOption.GetByIdWebsiteOption;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Admin")]
    public class WebsiteOptionController : ControllerBase
    {
        readonly IMediator _mediator;

        public WebsiteOptionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdWebsiteOptionQueryRequest getByIdWebsiteOptionQueryRequest )
        {
            GetByIdWebsiteOptionQueryResponse response = await _mediator.Send(getByIdWebsiteOptionQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateWebsiteOptionCommandRequest updateWebsiteOptionCommandRequest )
        {
            UpdateWebsiteOptionCommandResponse response = await _mediator.Send(updateWebsiteOptionCommandRequest);
            return Ok();
        }
    }
}
