using alsatminiode.Application.Repositories.PhoneSituationRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneSituation.CreatePhoneSituation
{
    public class CreatePhoneSituationCommandHandler : IRequestHandler<CreatePhoneSituationCommandRequest, CreatePhoneSituationCommandResponse>
    {
        readonly IPhoneSituationWriteRepository _phoneSituationWriteRepository;

        public CreatePhoneSituationCommandHandler(IPhoneSituationWriteRepository phoneSituationWriteRepository)
        {
            _phoneSituationWriteRepository = phoneSituationWriteRepository;
        }

        public async Task<CreatePhoneSituationCommandResponse> Handle(CreatePhoneSituationCommandRequest request, CancellationToken cancellationToken)
        {
            await _phoneSituationWriteRepository.AddAsync(new()
            {
                phoneSituation = request.phoneSituation
            });
            await _phoneSituationWriteRepository.SaveAsync();
            return new();
        }
    }
}
