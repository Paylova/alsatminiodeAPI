using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompany.CreateShippingCompany
{
    public class CreateShippingCompanyCommandHandler : IRequestHandler<CreateShippingCompanyCommandRequest, CreateShippingCompanyCommandResponse>
    {
        readonly IShippingCompanyWriteRepository _shippingCompanyWriteRepository;

        public CreateShippingCompanyCommandHandler(IShippingCompanyWriteRepository shippingCompanyWriteRepository)
        {
            _shippingCompanyWriteRepository = shippingCompanyWriteRepository;
        }

        public async Task<CreateShippingCompanyCommandResponse> Handle(CreateShippingCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _shippingCompanyWriteRepository.AddAsync(new()
            {
                companyName = request.companyName,
                companyDealCode = request.companyDealCode,
            });
            await _shippingCompanyWriteRepository.SaveAsync();
            return new();
        }
    }
}
