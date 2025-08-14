using alsatminiode.Application.Repositories.PhoneSituationRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneSituation.RemovePhoneSituation
{
    public class RemovePhoneSituationCommandHandler : IRequestHandler<RemovePhoneSituationCommandRequest, RemovePhoneSituationCommandResponse>
    {
        readonly IPhoneSituationWriteRepository _phoneSituationWriteRepository;

        public RemovePhoneSituationCommandHandler(IPhoneSituationWriteRepository phoneSituationWriteRepository)
        {
            _phoneSituationWriteRepository = phoneSituationWriteRepository;
        }

        public async Task<RemovePhoneSituationCommandResponse> Handle(RemovePhoneSituationCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneSituationWriteRepository.RemoveAsync(request.id);
            await _phoneSituationWriteRepository.SaveAsync();
            return new();
        }
    }
}
