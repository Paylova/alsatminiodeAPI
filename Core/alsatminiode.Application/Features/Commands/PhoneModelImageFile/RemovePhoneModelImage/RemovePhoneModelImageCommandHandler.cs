using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.PhoneModelImageFile.RemovePhoneModelImage
{
    public class RemovePhoneModelImageCommandHandler : IRequestHandler<RemovePhoneModelImageCommandRequest, RemovePhoneModelImageCommandResponse>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly IPhoneModelWriteRepository _phoneModelWriteRepository;

        public RemovePhoneModelImageCommandHandler(IPhoneModelReadRepository phoneModelReadRepository, IPhoneModelWriteRepository phoneModelWriteRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
            _phoneModelWriteRepository = phoneModelWriteRepository;
        }

        public async Task<RemovePhoneModelImageCommandResponse> Handle(RemovePhoneModelImageCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneModel? phoneModel = await _phoneModelReadRepository.Table.Include(p => p.phoneModelImageFile).FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));
            alsatminiode.Domain.Entities.PhoneModelImageFile? phoneModelImageFile = phoneModel?.phoneModelImageFile.FirstOrDefault(p => p.Id == Guid.Parse(request.imageId));
            if (phoneModelImageFile != null)
            {
                phoneModel.phoneModelImageFile.Remove(phoneModelImageFile);
            }
            await _phoneModelWriteRepository.SaveAsync();
            return new();
        }
    }
}
