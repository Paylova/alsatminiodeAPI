using alsatminiode.Application.Features.Commands.PhoneSituation.CreatePhoneSituation;
using alsatminiode.Application.Features.Commands.PhoneSituation.RemovePhoneSituation;
using alsatminiode.Application.Features.Commands.PhoneSituation.UpdatePhoneSituation;
using alsatminiode.Application.Features.Queries.PhoneSituation.GetAllPhoneSituation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class PhoneSituationController : ControllerBase
    {
        readonly IMediator _mediator;

        public PhoneSituationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPhoneSituationQueryRequest getAllPhoneSituationQueryRequest)
        {
            GetAllPhoneSituationQueryResponse response = await _mediator.Send(getAllPhoneSituationQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePhoneSituationCommandRequest createPhoneSituationCommandRequest)
        {
            CreatePhoneSituationCommandResponse response = await _mediator.Send(createPhoneSituationCommandRequest);
            return Ok((int)HttpStatusCode.Created);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemovePhoneSituationCommandRequest removePhoneSituationCommandRequest)
        {
            RemovePhoneSituationCommandResponse response = await _mediator.Send(removePhoneSituationCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePhoneSituationCommandRequest updatePhoneSituationCommandRequest)
        {
            UpdatePhoneSituationCommandResponse response = await _mediator.Send(updatePhoneSituationCommandRequest);
            return Ok();
        }

    }
}
