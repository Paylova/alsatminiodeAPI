using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.ShippingCompany.GetAllShippingCompanies
{
    public class GetAllShippingCompaniesQueryHandler : IRequestHandler<GetAllShippingCompaniesQueryRequest, GetAllShippingCompaniesQueryResponse>
    {
        readonly IShippingCompanyReadRepository _shippingCompanyReadRepository;

        public GetAllShippingCompaniesQueryHandler(IShippingCompanyReadRepository shippingCompanyReadRepository)
        {
            _shippingCompanyReadRepository = shippingCompanyReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllShippingCompaniesQueryResponse> Handle(GetAllShippingCompaniesQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _shippingCompanyReadRepository.GetAll(false).Count();
            var shippingCompany = _shippingCompanyReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
                .Select(p => new
                {
                    p.Id,
                    p.companyName,
                    p.companyDealCode,
                    CreatedDate = p.CreatedDate.ToShortDateString(),
                    UpdatedDate = p.UpdatedDate.ToShortDateString()
                }).ToList();
            return new()
            {
                shippingCompany = shippingCompany,
                totalCount = totalCount
            };
        }
    }
}
