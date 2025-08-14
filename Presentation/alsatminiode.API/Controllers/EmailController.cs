using alsatminiode.Application.Features.Commands.Email.SendEmail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        readonly IMediator _mediator;

        public EmailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromBody] SendEmailCommandRequest sendEmailCommandRequest)
        {
            SendEmailCommandResponse response = await _mediator.Send(sendEmailCommandRequest);
            return Ok();
        }
    }
}
