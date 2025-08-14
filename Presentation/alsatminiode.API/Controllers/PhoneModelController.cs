using alsatminiode.Application.Features.Commands.PhoneModel.CreatePhoneModel;
using alsatminiode.Application.Features.Commands.PhoneModel.RemovePhoneModel;
using alsatminiode.Application.Features.Commands.PhoneModel.UpdatePhoneModel;
using alsatminiode.Application.Features.Commands.PhoneModelImageFile.RemovePhoneModelImage;
using alsatminiode.Application.Features.Commands.PhoneModelImageFile.UploadPhoneModelImage;
using alsatminiode.Application.Features.Queries.PhoneModel.GetAllPhoneModel;
using alsatminiode.Application.Features.Queries.PhoneModel.GetByIdPhoneModel;
using alsatminiode.Application.Features.Queries.PhoneModelImageFile.GetAllPhoneModelImageFile;
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
    public class PhoneModelController : ControllerBase
    {
        IMediator _mediator;

        public PhoneModelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPhoneModelQueryRequest getAllPhoneModelQueryRequest)
        {
            GetAllPhoneModelQueryResponse response = await _mediator.Send(getAllPhoneModelQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdPhoneModelQueryRequest getByIdPhoneModelQueryRequest)
        {
            GetByIdPhoneModelQueryResponse response = await _mediator.Send(getByIdPhoneModelQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePhoneModelCommandRequest createPhoneModelCommandRequest)
        {
            CreatePhoneModelCommandResponse response = await _mediator.Send(createPhoneModelCommandRequest);
            return Ok((int)HttpStatusCode.Created);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemovePhoneModelCommandRequest removePhoneModelCommandRequest)
        {
            RemovePhoneModelCommandResponse response = await _mediator.Send(removePhoneModelCommandRequest);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadPhoneModelImageCommandRequest uploadPhoneModelImageCommandRequest)
        {
            uploadPhoneModelImageCommandRequest.Files = Request.Form.Files;
            UploadPhoneModelImageCommandResponse response = await _mediator.Send(uploadPhoneModelImageCommandRequest);
            return Ok();
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetPhoneModelImages([FromRoute] GetPhoneModelImagesQueryRequest getPhoneModelImagesQueryRequest)
        {
            List<GetPhoneModelImagesQueryResponse> response = await _mediator.Send(getPhoneModelImagesQueryRequest);
            return Ok(response);
        }
        [HttpDelete("[action]/{id}/{imageId}")]
        public async Task<IActionResult> DeletePhoneModelImages([FromRoute] RemovePhoneModelImageCommandRequest removePhoneModelImageCommandRequest,[FromQuery] string imageId)
        {
            removePhoneModelImageCommandRequest.imageId = imageId;
            RemovePhoneModelImageCommandResponse response = await _mediator.Send(removePhoneModelImageCommandRequest);
            return Ok();
        }



        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePhoneModelCommandRequest updatePhoneModelCommandRequest)
        {
            UpdatePhoneModelCommandResponse response = await _mediator.Send(updatePhoneModelCommandRequest);
            return Ok();
        }
    }
}
