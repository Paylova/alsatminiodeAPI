using alsatminiode.Application.Features.Queries.PhoneBrandImageFile.GetSinglePhoneBrandImageFile;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetSinglePhoneBrandController : ControllerBase
    {
        readonly IMediator _mediator;

        public GetSinglePhoneBrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetSinglePhoneBrandImage([FromRoute] GetSinglePhoneBrandImagesQueryRequest getSinglePhoneBrandImagesQueryRequest)
        {
            GetSinglePhoneBrandImagesQueryResponse response = await _mediator.Send(getSinglePhoneBrandImagesQueryRequest);
            return Ok(response);
        }
    }
}
