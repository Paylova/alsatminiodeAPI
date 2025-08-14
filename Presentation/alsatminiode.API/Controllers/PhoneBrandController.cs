using alsatminiode.Application.Features.Commands.PhoneBrand.CreatePhoneBrand;
using alsatminiode.Application.Features.Commands.PhoneBrand.RemovePhoneBrand;
using alsatminiode.Application.Features.Commands.PhoneBrand.UpdatePhoneBrand;
using alsatminiode.Application.Features.Commands.PhoneBrandImageFile.CreatePhoneBrandImageFile;
using alsatminiode.Application.Features.Commands.PhoneBrandImageFile.RemovePhoneBrandImageFile;
using alsatminiode.Application.Features.Queries.PhoneBrand.GetAllPhoneBrand;
using alsatminiode.Application.Features.Queries.PhoneBrand.GetSinglePhoneBrand;
using alsatminiode.Application.Features.Queries.PhoneBrandImageFile.GetAllPhoneBrandImageFile;
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
    public class PhoneBrandController : ControllerBase
    {
        readonly IMediator _mediator;

        public PhoneBrandController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPhoneBrandQueryRequest getAllPhoneBrandQueryRequest)
        {
            GetAllPhoneBrandQueryResponse response = await _mediator.Send(getAllPhoneBrandQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetSinglePhoneBrandQueryRequest getSinglePhoneBrandQueryRequest)
        {
            GetSinglePhoneBrandQueryResponse response = await _mediator.Send(getSinglePhoneBrandQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePhoneBrandCommandRequest createPhoneBrandCommandRequest)
        {
            CreatePhoneBrandCommandResponse response = await _mediator.Send(createPhoneBrandCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemovePhoneBrandCommandRequest removePhoneBrandCommandRequest)
        {
            RemovePhoneBrandCommandResponse response = await _mediator.Send(removePhoneBrandCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePhoneBrandCommandRequest updatePhoneBrandCommandRequest)
        {
            UpdatePhoneBrandCommandResponse response = await _mediator.Send(updatePhoneBrandCommandRequest);
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] CreatePhoneBrandImageFileCommandRequest createPhoneBrandImageFileCommandRequest)
        {
            createPhoneBrandImageFileCommandRequest.Files = Request.Form.Files;
            CreatePhoneBrandImageFileCommandResponse response = await _mediator.Send(createPhoneBrandImageFileCommandRequest);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetPhoneBrandImages([FromRoute] GetPhoneBrandImagesQueryRequest getPhoneBrandImagesQueryRequest)
        {
            List<GetPhoneBrandImagesQueryResponse> response = await _mediator.Send(getPhoneBrandImagesQueryRequest);
            return Ok(response);
        }
        [HttpDelete("[action]/{id}/{imageId}")]
        public async Task<IActionResult> DeletePhoneBrandImages([FromRoute] RemovePhoneBrandImageFileCommandRequest removePhoneBrandImageFileCommandRequest,[FromQuery] string imageId)
        {
            removePhoneBrandImageFileCommandRequest.imageId = imageId;
            RemovePhoneBrandImageFileCommandResponse response = await _mediator.Send(removePhoneBrandImageFileCommandRequest);
            return Ok();
        }


    }
}
