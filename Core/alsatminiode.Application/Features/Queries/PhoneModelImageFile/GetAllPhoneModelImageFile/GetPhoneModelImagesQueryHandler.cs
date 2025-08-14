using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelImageFile.GetAllPhoneModelImageFile
{
    public class GetPhoneModelImagesQueryHandler : IRequestHandler<GetPhoneModelImagesQueryRequest, List<GetPhoneModelImagesQueryResponse>>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        readonly IConfiguration configuration;

        public GetPhoneModelImagesQueryHandler(IPhoneModelReadRepository phoneModelReadRepository, IConfiguration configuration)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
            this.configuration = configuration;
        }

        public async Task<List<GetPhoneModelImagesQueryResponse>?> Handle(GetPhoneModelImagesQueryRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.PhoneModel? phoneModel = await _phoneModelReadRepository.Table.Include(p => p.phoneModelImageFile).FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));
            return phoneModel?.phoneModelImageFile.Select(p => new GetPhoneModelImagesQueryResponse
            {
                FilePath = $"{configuration["BaseStorageUrl"]}/{p.FilePath}",
                FileName = p.FileName,
                id = p.Id
            }).ToList();
        }
    }
}
