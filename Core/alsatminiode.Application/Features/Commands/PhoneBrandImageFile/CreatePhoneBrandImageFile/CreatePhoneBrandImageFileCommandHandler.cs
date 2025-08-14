using alsatminiode.Application.Abstractions.Storage;
using alsatminiode.Application.Repositories.PhoneBrandImageFileRepo;
using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Features.Commands.PhoneBrandImageFile.CreatePhoneBrandImageFile
{
    public class CreatePhoneBrandImageFileCommandHandler : IRequestHandler<CreatePhoneBrandImageFileCommandRequest, CreatePhoneBrandImageFileCommandResponse>
    {
        readonly IStorageService _storageService;
        readonly IPhoneBrandImageFileWriteRepository _phoneBrandImageFileWriteRepository;
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;

        public CreatePhoneBrandImageFileCommandHandler(IStorageService storageService, IPhoneBrandImageFileWriteRepository phoneBrandImageFileWriteRepository, IPhoneBrandReadRepository phoneBrandReadRepository)
        {
            _storageService = storageService;
            _phoneBrandImageFileWriteRepository = phoneBrandImageFileWriteRepository;
            _phoneBrandReadRepository = phoneBrandReadRepository;
        }
        public async Task<CreatePhoneBrandImageFileCommandResponse> Handle(CreatePhoneBrandImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("resource/phone-brand-images", request.Files);
            alsatminiode.Domain.Entities.PhoneBrand phoneBrand = await _phoneBrandReadRepository.GetByIdAsync(request.id);
            await _phoneBrandImageFileWriteRepository.AddRangeAsync(result.Select(r => new F::PhoneBrandImageFile
            {
                FileName = r.fileName,
                FilePath = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                phoneBrand = new List<alsatminiode.Domain.Entities.PhoneBrand>() { phoneBrand}
            }).ToList());
            await _phoneBrandImageFileWriteRepository.SaveAsync();
            return new();
        }
    }
}
