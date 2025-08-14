using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.ShippingCompany.GetByIdShippingCompany
{
    public class GetByIdShippingComapnyQueryHandler : IRequestHandler<GetByIdShippingComapnyQueryRequest, GetByIdShippingComapnyQueryResponse>
    {
        readonly IShippingCompanyReadRepository _shippingCompanyReadRepository;

        public GetByIdShippingComapnyQueryHandler(IShippingCompanyReadRepository shippingCompanyReadRepository)
        {
            _shippingCompanyReadRepository = shippingCompanyReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetByIdShippingComapnyQueryResponse> Handle(GetByIdShippingComapnyQueryRequest request, CancellationToken cancellationToken)
        {
            var shippingCompany = _shippingCompanyReadRepository.GetWhere(c => c.Id == Guid.Parse(request.id))
                .Include(c => c.shippingCompanyImageFile)
                .Select(c => new
            {
                c.Id,
                c.companyName,
                c.companyDealCode,
                c.shippingCompanyImageFile,
                CreatedDate = c.CreatedDate.ToShortDateString(),
                UpdatedDate = c.UpdatedDate.ToShortDateString()
            });
            return new()
            {
                shippingCompany = shippingCompany,
            };
        }
    }
}
