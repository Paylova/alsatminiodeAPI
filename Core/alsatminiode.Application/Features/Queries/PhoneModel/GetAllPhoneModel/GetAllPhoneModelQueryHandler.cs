using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModel.GetAllPhoneModel
{
    public class GetAllPhoneModelQueryHandler : IRequestHandler<GetAllPhoneModelQueryRequest, GetAllPhoneModelQueryResponse>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;

        public GetAllPhoneModelQueryHandler(IPhoneModelReadRepository phoneModelReadRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllPhoneModelQueryResponse> Handle(GetAllPhoneModelQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _phoneModelReadRepository.GetAll(false).Count();
            var phoneModel = _phoneModelReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
                .Include(m => m.phoneModelImageFile)
                .Select(m => new
            {
                m.Id,
                m.modelName,
                m.modelFirstPrice,
                m.modelLastPrice,
                m.modelBrand.brandName,
                CreatedDate =  m.CreatedDate.ToShortDateString(),
                UpdatedDate= m.UpdatedDate.ToShortDateString(),
                m.phoneModelImageFile
                });

            return new()
            {
                totalCount = totalCount,
                phoneModel = phoneModel
            };
        }
    }
}
