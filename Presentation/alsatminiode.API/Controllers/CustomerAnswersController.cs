using alsatminiode.Application.Features.Commands.CustomerAnswers.CreateCustomerAnswers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAnswersController : ControllerBase
    {
        readonly IMediator _mediator;

        public CustomerAnswersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerAnswersCommandRequest createCustomerAnswersCommandRequest)
        {
            CreateCustomerAnswersCommandResponse response = await _mediator.Send(createCustomerAnswersCommandRequest);
            return Ok();
        }
    }
}
