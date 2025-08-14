using alsatminiode.Application.Features.Commands.Customer.SendGSM;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendGSMCustomerController : ControllerBase
    {
        IMediator _mediator;

        public SendGSMCustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SendGsmCustomerCommandRequest sendGsmCustomerCommandRequest)
        {
            SendGsmCustomerCommandResponse response = await _mediator.Send(sendGsmCustomerCommandRequest);
            return Ok();
        }
    }
}
