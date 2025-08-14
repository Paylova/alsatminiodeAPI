using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneBrandImageFile.RemovePhoneBrandImageFile
{
    public class RemovePhoneBrandImageFileCommandHandler : IRequestHandler<RemovePhoneBrandImageFileCommandRequest, RemovePhoneBrandImageFileCommandResponse>
    {

        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;
        readonly IPhoneBrandWriteRepository _phoneBrandWriteRepository;

        public RemovePhoneBrandImageFileCommandHandler(IPhoneBrandReadRepository phoneBrandReadRepository, IPhoneBrandWriteRepository phoneBrandWriteRepository)
        {
            _phoneBrandReadRepository = phoneBrandReadRepository;
            _phoneBrandWriteRepository = phoneBrandWriteRepository;
        }

        public async Task<RemovePhoneBrandImageFileCommandResponse> Handle(RemovePhoneBrandImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneBrand? phoneBrand = await _phoneBrandReadRepository.Table.Include(p => p.phoneBrandImageFile)
                    .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));

            alsatminiode.Domain.Entities.PhoneBrandImageFile? phoneBrandImageFile = phoneBrand?.phoneBrandImageFile.FirstOrDefault(p => p.Id == Guid.Parse(request.imageId));
            if (phoneBrandImageFile != null)
            {
                phoneBrand?.phoneBrandImageFile.Remove(phoneBrandImageFile);
            }
            await _phoneBrandWriteRepository.SaveAsync();
            return new();
        }
    }
}
