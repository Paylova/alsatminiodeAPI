using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneQuestion.CreatePhoneQuestion
{
    public class CreatePhoneQuestionCommandHandler : IRequestHandler<CreatePhoneQuestionCommandRequest, CreatePhoneQuestionCommandResponse>
    {
        readonly IPhoneQuestionWriteRepository _phoneQuestionWriteRepository;

        public CreatePhoneQuestionCommandHandler(IPhoneQuestionWriteRepository phoneQuestionWriteRepository)
        {
            _phoneQuestionWriteRepository = phoneQuestionWriteRepository;
        }

        public async Task<CreatePhoneQuestionCommandResponse> Handle(CreatePhoneQuestionCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneQuestionWriteRepository.AddAsync(new()
            {
                QuestionText = request.QuestionText,

            });
            await _phoneQuestionWriteRepository.SaveAsync();

            return new();
        }
    }
}
