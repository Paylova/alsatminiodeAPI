using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompany.UpdateShippingCompany
{
    public class UpdateShippingCompanyCommandHandler : IRequestHandler<UpdateShippingCompanyCommandRequest, UpdateShippingCompanyCommandResponse>
    {
        readonly IShippingCompanyReadRepository _shippingCompanyReadRepository;
        readonly IShippingCompanyWriteRepository _shippingCompanyWriteRepository;

        public UpdateShippingCompanyCommandHandler(IShippingCompanyReadRepository shippingCompanyReadRepository, IShippingCompanyWriteRepository shippingCompanyWriteRepository)
        {
            _shippingCompanyReadRepository = shippingCompanyReadRepository;
            _shippingCompanyWriteRepository = shippingCompanyWriteRepository;
        }

        public async Task<UpdateShippingCompanyCommandResponse> Handle(UpdateShippingCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.ShippingCompany shippingCompany = await _shippingCompanyReadRepository.GetByIdAsync(request.id);
            shippingCompany.companyName = request.companyName;
            shippingCompany.companyDealCode = request.companyDealCode;
            await _shippingCompanyWriteRepository.SaveAsync();
            return new();
        }
    }
}
