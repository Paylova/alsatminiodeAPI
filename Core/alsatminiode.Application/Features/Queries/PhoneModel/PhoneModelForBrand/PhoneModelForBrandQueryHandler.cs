using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModel.PhoneModelForBrand
{
    public class PhoneModelForBrandQueryHandler : IRequestHandler<PhoneModelForBrandQueryRequest, PhoneModelForBrandQueryResponse>
    {
        IPhoneModelReadRepository _phoneModelReadRepository;

        public PhoneModelForBrandQueryHandler(IPhoneModelReadRepository phoneModelReadRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
        }
        public async Task<PhoneModelForBrandQueryResponse> Handle(PhoneModelForBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneModel = _phoneModelReadRepository.GetWhere(p => p.modelBrand.Id == Guid.Parse(request.id))
                .Include(p => p.phoneModelImageFile)
                .OrderByDescending(x => x.CreatedDate)
                .Select(m => new
                {
                    m.Id,
                    m.modelName,
                    m.modelFirstPrice,
                    m.modelLastPrice,
                    m.modelBrand,
                    m.phoneModelImageFile,
                    CreatedDate = m.CreatedDate.ToShortDateString(),
                    UpdatedDate = m.UpdatedDate.ToShortDateString(),
                });

            return new()
            {
                phoneModel = phoneModel
            };
        }
    }
}
