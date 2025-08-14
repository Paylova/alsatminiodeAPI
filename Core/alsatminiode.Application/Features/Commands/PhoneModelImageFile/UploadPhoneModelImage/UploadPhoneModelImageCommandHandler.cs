using alsatminiode.Application.Abstractions.Storage;
using alsatminiode.Application.Repositories.PhoneModelImageRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Features.Commands.PhoneModelImageFile.UploadPhoneModelImage
{
    public class UploadPhoneModelImageCommandHandler : IRequestHandler<UploadPhoneModelImageCommandRequest, UploadPhoneModelImageCommandResponse>
    {
        readonly IStorageService _storageService;
        readonly IPhoneModelImageFileWriteRepository _phoneModelImageFileWriteRepository;
        readonly IPhoneModelReadRepository _phoneModelReadRepository;

        public UploadPhoneModelImageCommandHandler(IStorageService storageService, IPhoneModelImageFileWriteRepository phoneModelImageFileWriteRepository, IPhoneModelReadRepository phoneModelReadRepository)
        {
            _storageService = storageService;
            _phoneModelImageFileWriteRepository = phoneModelImageFileWriteRepository;
            _phoneModelReadRepository = phoneModelReadRepository;
        }

        public async Task<UploadPhoneModelImageCommandResponse> Handle(UploadPhoneModelImageCommandRequest request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("resource/phoneModel-images", request.Files);
            alsatminiode.Domain.Entities.PhoneModel phoneModel = await _phoneModelReadRepository.GetByIdAsync(request.id);
            await _phoneModelImageFileWriteRepository.AddRangeAsync(result.Select(r => new F::PhoneModelImageFile
            {
                FileName = r.fileName,
                FilePath = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                phoneModel = new List<alsatminiode.Domain.Entities.PhoneModel>() { phoneModel }
            }).ToList());
            await _phoneModelImageFileWriteRepository.SaveAsync();
            return new();
        }
    }
}
