using alsatminiode.Application.Repositories.PhoneBrandRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrandImageFile.GetSinglePhoneBrandImageFile
{
    
    public class GetSinglePhoneBrandImagesQueryHandler : IRequestHandler<GetSinglePhoneBrandImagesQueryRequest, GetSinglePhoneBrandImagesQueryResponse>
    {
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;
        readonly IConfiguration configuration;

        public GetSinglePhoneBrandImagesQueryHandler(IPhoneBrandReadRepository phoneBrandReadRepository, IConfiguration configuration)
        {
            _phoneBrandReadRepository = phoneBrandReadRepository;
            this.configuration = configuration;
        }

        public async Task<GetSinglePhoneBrandImagesQueryResponse?> Handle(GetSinglePhoneBrandImagesQueryRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneBrand? phoneBrand = await _phoneBrandReadRepository.Table.Include(p => p.phoneBrandImageFile)
        .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));

            GetSinglePhoneBrandImagesQueryResponse? response  = (GetSinglePhoneBrandImagesQueryResponse?)(phoneBrand?.phoneBrandImageFile.Select(p => new GetSinglePhoneBrandImagesQueryResponse
            {
                FilePath = $"{configuration["BaseStorageUrl"]}/{p.FilePath}",
                FileName = p.FileName,
                id = p.Id
            }));
            return new()
            {
                FilePath = response.FilePath,
                FileName = response.FileName,
                id = response.id

            };


        }
    }
}
