using alsatminiode.Application.Abstractions.Storage;
using alsatminiode.Application.Repositories.ShippingCompanyImageFileRepo;
using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompanyImageFile.UploadShippingCompanyImageFile
{
    public class UploadShippingCompanyImageFileCommandHandler : IRequestHandler<UploadShippingCompanyImageFileCommandRequest, UploadShippingCompanyImageFileCommandResponse>
    {
        readonly IStorageService _storageService;
        readonly IShippingCompanyImageFileWriteRepository _shippingCompanyImageFileWriteRepository;
        readonly IShippingCompanyReadRepository _shippingCompanyReadRepository;

        public UploadShippingCompanyImageFileCommandHandler(IStorageService storageService, IShippingCompanyImageFileWriteRepository shippingCompanyImageFileWriteRepository, IShippingCompanyReadRepository shippingCompanyReadRepository)
        {
            _storageService = storageService;
            _shippingCompanyImageFileWriteRepository = shippingCompanyImageFileWriteRepository;
            _shippingCompanyReadRepository = shippingCompanyReadRepository;
        }

        public async Task<UploadShippingCompanyImageFileCommandResponse> Handle(UploadShippingCompanyImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("resource/shippingCompany-images", request.Files);
            alsatminiode.Domain.Entities.ShippingCompany shippingCompany = await _shippingCompanyReadRepository.GetByIdAsync(request.id);
            await _shippingCompanyImageFileWriteRepository.AddRangeAsync(result.Select(r => new alsatminiode.Domain.Entities.ShippingCompanyImageFile
            {
                FileName = r.fileName,
                FilePath = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                shippingCompany = new List<alsatminiode.Domain.Entities.ShippingCompany>() { shippingCompany }
            }).ToList());
            await _shippingCompanyImageFileWriteRepository.SaveAsync();
            return new();
        }
    }
}
