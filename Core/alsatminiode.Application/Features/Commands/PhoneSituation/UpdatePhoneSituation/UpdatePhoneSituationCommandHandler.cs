using alsatminiode.Application.Repositories.PhoneSituationRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneSituation.UpdatePhoneSituation
{
    public class UpdatePhoneSituationCommandHandler : IRequestHandler<UpdatePhoneSituationCommandRequest, UpdatePhoneSituationCommandResponse>
    {
        readonly IPhoneSituationReadRepository _phoneSituationReadRepository;
        readonly IPhoneSituationWriteRepository _phoneSituationWriteRepository;

        public UpdatePhoneSituationCommandHandler(IPhoneSituationReadRepository phoneSituationReadRepository, IPhoneSituationWriteRepository phoneSituationWriteRepository)
        {
            _phoneSituationReadRepository = phoneSituationReadRepository;
            _phoneSituationWriteRepository = phoneSituationWriteRepository;
        }

        public async Task<UpdatePhoneSituationCommandResponse> Handle(UpdatePhoneSituationCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneSituation phoneSituation = await _phoneSituationReadRepository.GetByIdAsync(request.id);
            phoneSituation.phoneSituation = request.phoneSituation;
            await _phoneSituationWriteRepository.SaveAsync();
            return new();
        }
    }
}
