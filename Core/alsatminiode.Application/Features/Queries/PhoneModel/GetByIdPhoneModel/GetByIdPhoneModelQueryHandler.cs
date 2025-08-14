using alsatminiode.Application.Repositories.PhoneModelRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModel.GetByIdPhoneModel
{
    public class GetByIdPhoneModelQueryHandler : IRequestHandler<GetByIdPhoneModelQueryRequest, GetByIdPhoneModelQueryResponse>
    {
        readonly IPhoneModelReadRepository _phoneModelReadRepository;

        public GetByIdPhoneModelQueryHandler(IPhoneModelReadRepository phoneModelReadRepository)
        {
            _phoneModelReadRepository = phoneModelReadRepository;
        }

        public async Task<GetByIdPhoneModelQueryResponse> Handle(GetByIdPhoneModelQueryRequest request, CancellationToken cancellationToken)
        {
            var phonemodel = _phoneModelReadRepository.GetWhere(c => c.Id == Guid.Parse(request.id)).Select(c => new
            {
                c.Id,
                c.modelName,
                c.modelFirstPrice,
                c.modelLastPrice
            });
            return new()
            {
                phoneModel = phonemodel,
            };
        }
    }
}
