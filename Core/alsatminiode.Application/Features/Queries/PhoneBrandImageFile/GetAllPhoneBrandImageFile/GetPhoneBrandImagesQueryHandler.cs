using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrandImageFile.GetAllPhoneBrandImageFile
{
    public class GetPhoneBrandImagesQueryHandler : IRequestHandler<GetPhoneBrandImagesQueryRequest, List<GetPhoneBrandImagesQueryResponse>>
    {
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;
        readonly IConfiguration configuration;

        public GetPhoneBrandImagesQueryHandler(IPhoneBrandReadRepository phoneBrandReadRepository, IConfiguration configuration)
        {
            _phoneBrandReadRepository = phoneBrandReadRepository;
            this.configuration = configuration;
        }

        public async Task<List<GetPhoneBrandImagesQueryResponse>?> Handle(GetPhoneBrandImagesQueryRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneBrand? phoneBrand = await _phoneBrandReadRepository.Table.Include(p => p.phoneBrandImageFile)
        .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));
            return phoneBrand?.phoneBrandImageFile.Select(p => new GetPhoneBrandImagesQueryResponse
            {
                FilePath = $"{configuration["BaseStorageUrl"]}/{p.FilePath}",
                FileName = p.FileName,
                id = p.Id                           
            }).ToList();
        }
    }
}
