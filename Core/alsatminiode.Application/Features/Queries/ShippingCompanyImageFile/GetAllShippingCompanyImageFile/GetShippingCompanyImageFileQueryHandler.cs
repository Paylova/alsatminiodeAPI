using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.ShippingCompanyImageFile.GetAllShippingCompanyImageFile
{
    public class GetShippingCompanyImageFileQueryHandler : IRequestHandler<GetShippingCompanyImageFileQueryRequest, List<GetShippingCompanyImageFileQueryResponse>>
    {
        readonly IShippingCompanyReadRepository _shippingCompanyReadRepository;
        readonly IConfiguration configuration;

        public GetShippingCompanyImageFileQueryHandler(IShippingCompanyReadRepository shippingCompanyReadRepository, IConfiguration configuration)
        {
            _shippingCompanyReadRepository = shippingCompanyReadRepository;
            this.configuration = configuration;
        }

        public async Task<List<GetShippingCompanyImageFileQueryResponse>?> Handle(GetShippingCompanyImageFileQueryRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.ShippingCompany? shippingCompany = await _shippingCompanyReadRepository.Table.Include(p => p.shippingCompanyImageFile).FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));
            return shippingCompany?.shippingCompanyImageFile.Select(p => new GetShippingCompanyImageFileQueryResponse
            {
                FilePath = $"{configuration["BaseStorageUrl"]}/{p.FilePath}",
                FileName = p.FileName,
                id = p.Id
            }).ToList();
        }
    }
}
