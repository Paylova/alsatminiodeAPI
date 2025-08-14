using alsatminiode.Application.Abstractions;
using alsatminiode.Application.Abstractions.Storage;
using alsatminiode.Application.Features.Commands.PhoneQuestion.CreatePhoneQuestion;
using alsatminiode.Application.Features.Commands.PhoneQuestion.DeletePhoneQuestion;
using alsatminiode.Application.Features.Commands.PhoneQuestion.UpdatePhoneQuestion;
using alsatminiode.Application.Features.Queries.PhoneQuestion.GetAllPhoneQuestion;
using alsatminiode.Application.Features.Queries.PhoneQuestion.GetByIdPhoneQuestion;
using alsatminiode.Application.Repositories.FileRepo;
using alsatminiode.Application.Repositories.PhoneModelImageRepo;
using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using alsatminiode.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace alsatminiode.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class PhoneQuestionsController : ControllerBase
    {
        readonly IPhoneQuestionWriteRepository _phoneQuestionWriteRepository;
        readonly IPhoneModelImageFileWriteRepository _phoneModelImageFileWriteRepository;
        readonly IStorageService _storageService;
        readonly IMediator _mediator;


        public PhoneQuestionsController(IPhoneQuestionWriteRepository phoneQuestionWriteRepository, IWebHostEnvironment webHostEnvironment, IPhoneQuestionReadRepository phoneQuestionReadRepository, IFileWriteRepository fileWriteRepository, IFileReadRepository fileReadRepository, IPhoneModelImageFileReadRepository phoneModelImageFileReadRepository, IPhoneModelImageFileWriteRepository phoneModelImageFileWriteRepository, IStorageService storageService, IMediator mediator)
        {
            _phoneQuestionWriteRepository = phoneQuestionWriteRepository;
            _phoneModelImageFileWriteRepository = phoneModelImageFileWriteRepository;
            _storageService = storageService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPhoneQuestionQueryRequest getAllPhoneQuestionQueryRequest)
        {
            GetAllPhoneQuestionQueryResponse response = await _mediator.Send(getAllPhoneQuestionQueryRequest);
            return Ok(response);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdPhoneQuestionQueryRequest getByIdPhoneQuestionQueryRequest)
        {
            GetByIdPhoneQuestionQueryResponse response = await _mediator.Send(getByIdPhoneQuestionQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreatePhoneQuestionCommandRequest createPhoneQuestionCommandRequest)
        {

            CreatePhoneQuestionCommandResponse response = await _mediator.Send(createPhoneQuestionCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePhoneQuestionCommandRequest updatePhoneQuestionCommandRequest)
        {
            UpdatePhoneQuestionCommandResponse response = await _mediator.Send(updatePhoneQuestionCommandRequest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] DeletePhoneQuestionCommandRequest deletePhoneQuestionCommandRequest)
        {
            DeletePhoneQuestionCommandResponse response = await _mediator.Send(deletePhoneQuestionCommandRequest);   
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload(string id)
        {
           List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("resource/phoneModel-images", Request.Form.Files);
            await _phoneModelImageFileWriteRepository.AddRangeAsync(result.Select(d => new PhoneModelImageFile()
            {
                FileName = d.fileName,
                FilePath = d.pathOrContainerName,
                Storage = _storageService.StorageName,
                
                
            }).ToList());
            await _phoneQuestionWriteRepository.SaveAsync();
            return Ok();
        }

    }
}
