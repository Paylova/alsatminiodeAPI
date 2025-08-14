using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneQuestion.UpdatePhoneQuestion
{
    public class UpdatePhoneQuestionCommandHandler : IRequestHandler<UpdatePhoneQuestionCommandRequest, UpdatePhoneQuestionCommandResponse>
    {
        readonly IPhoneQuestionReadRepository _phoneQuestionReadRepository;
        readonly IPhoneQuestionWriteRepository _phoneQuestionWriteRepository;

        public UpdatePhoneQuestionCommandHandler(IPhoneQuestionReadRepository phoneQuestionReadRepository, IPhoneQuestionWriteRepository phoneQuestionWriteRepository)
        {
            _phoneQuestionReadRepository = phoneQuestionReadRepository;
            _phoneQuestionWriteRepository = phoneQuestionWriteRepository;
        }




        public async Task<UpdatePhoneQuestionCommandResponse> Handle(UpdatePhoneQuestionCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneQuestion phoneQuestion = await _phoneQuestionReadRepository.GetByIdAsync(request.id);
            phoneQuestion.QuestionText = request.QuestionText;
            await _phoneQuestionWriteRepository.SaveAsync();

            return new();
        }
    }
}
