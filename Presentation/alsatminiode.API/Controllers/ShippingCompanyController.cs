using alsatminiode.Application.Features.Commands.ShippingCompany.CreateShippingCompany;
using alsatminiode.Application.Features.Commands.ShippingCompany.RemoveShippingCompany;
using alsatminiode.Application.Features.Commands.ShippingCompany.UpdateShippingCompany;
using alsatminiode.Application.Features.Commands.ShippingCompanyImageFile.RemoveShippingCompanyImageFile;
using alsatminiode.Application.Features.Commands.ShippingCompanyImageFile.UploadShippingCompanyImageFile;
using alsatminiode.Application.Features.Queries.ShippingCompany.GetAllShippingCompanies;
using alsatminiode.Application.Features.Queries.ShippingCompany.GetByIdShippingCompany;
using alsatminiode.Application.Features.Queries.ShippingCompanyImageFile.GetAllShippingCompanyImageFile;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingCompanyController : ControllerBase
    {
        IMediator _mediator;

        public ShippingCompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllShippingCompaniesQueryRequest getAllShippingCompaniesQueryRequest)
        {
            GetAllShippingCompaniesQueryResponse response = await _mediator.Send(getAllShippingCompaniesQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdShippingComapnyQueryRequest getByIdShippingComapnyQueryRequest)
        {
            GetByIdShippingComapnyQueryResponse response = await _mediator.Send(getByIdShippingComapnyQueryRequest);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateShippingCompanyCommandRequest createShippingCompanyCommandRequest)
        {
            CreateShippingCompanyCommandResponse response = await _mediator.Send(createShippingCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveShippingCompanyCommandRequest removeShippingCompanyCommandRequest)
        {
            RemoveShippingCompanyCommandResponse response = await _mediator.Send(removeShippingCompanyCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateShippingCompanyCommandRequest updateShippingCompanyCommandRequest)
        {
            UpdateShippingCompanyCommandResponse response = await _mediator.Send(updateShippingCompanyCommandRequest);
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadShippingCompanyImageFileCommandRequest uploadShippingCompanyImageFileCommandRequest)
        {
            uploadShippingCompanyImageFileCommandRequest.Files = Request.Form.Files;
            UploadShippingCompanyImageFileCommandResponse response = await _mediator.Send(uploadShippingCompanyImageFileCommandRequest);
            return Ok();
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetShippingCompanyImageFile([FromRoute] GetShippingCompanyImageFileQueryRequest getShippingCompanyImageFileQueryRequest)
        {
            List<GetShippingCompanyImageFileQueryResponse> response = await _mediator.Send(getShippingCompanyImageFileQueryRequest);
            return Ok(response);
        }
        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteShippingCompanyImageFile([FromRoute] RemoveShippingCompanyImageFileCommandRequest removeShippingCompanyImageFileCommandRequest, [FromQuery] string imageId)
        {
            removeShippingCompanyImageFileCommandRequest.ImageId = imageId;
            RemoveShippingCompanyImageFileCommandResponse response = await _mediator.Send(removeShippingCompanyImageFileCommandRequest);
            return Ok();
        }
    }
}
