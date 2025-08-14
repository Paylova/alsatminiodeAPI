using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompany.RemoveShippingCompany
{
    public class RemoveShippingCompanyCommandHandler : MediatR.IRequestHandler<RemoveShippingCompanyCommandRequest, RemoveShippingCompanyCommandResponse>
    {
        readonly IShippingCompanyWriteRepository _shippingCompanyWriteRepository;

        public RemoveShippingCompanyCommandHandler(IShippingCompanyWriteRepository shippingCompanyWriteRepository)
        {
            _shippingCompanyWriteRepository = shippingCompanyWriteRepository;
        }

        public async Task<RemoveShippingCompanyCommandResponse> Handle(RemoveShippingCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _shippingCompanyWriteRepository.RemoveAsync(request.id);
            await _shippingCompanyWriteRepository.SaveAsync();
            return new();
        }
    }
}
