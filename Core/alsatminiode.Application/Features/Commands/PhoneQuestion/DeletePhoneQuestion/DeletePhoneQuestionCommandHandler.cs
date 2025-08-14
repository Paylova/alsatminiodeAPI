using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneQuestion.DeletePhoneQuestion
{
    public class DeletePhoneQuestionCommandHandler : IRequestHandler<DeletePhoneQuestionCommandRequest, DeletePhoneQuestionCommandResponse>
    {
        readonly IPhoneQuestionWriteRepository _phoneQuestionWriteRepository;

        public DeletePhoneQuestionCommandHandler(IPhoneQuestionWriteRepository phoneQuestionWriteRepository)
        {
            _phoneQuestionWriteRepository = phoneQuestionWriteRepository;
        }

        public async Task<DeletePhoneQuestionCommandResponse> Handle(DeletePhoneQuestionCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneQuestionWriteRepository.RemoveAsync(request.id);
            await _phoneQuestionWriteRepository.SaveAsync();

            return new();
        }
    }
}
