using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompanyImageFile.RemoveShippingCompanyImageFile
{
    public class RemoveShippingCompanyImageFileCommandHandler : IRequestHandler<RemoveShippingCompanyImageFileCommandRequest, RemoveShippingCompanyImageFileCommandResponse>
    {
        readonly IShippingCompanyReadRepository _shippingCompanyReadRepository;
        readonly IShippingCompanyWriteRepository _shippingCompanyWriteRepository;

        public RemoveShippingCompanyImageFileCommandHandler(IShippingCompanyReadRepository shippingCompanyReadRepository, IShippingCompanyWriteRepository shippingCompanyWriteRepository)
        {
            _shippingCompanyReadRepository = shippingCompanyReadRepository;
            _shippingCompanyWriteRepository = shippingCompanyWriteRepository;
        }

        public async Task<RemoveShippingCompanyImageFileCommandResponse> Handle(RemoveShippingCompanyImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.ShippingCompany shippingCompany = await _shippingCompanyReadRepository.Table.Include(p => p.shippingCompanyImageFile)
    .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.id));
            Domain.Entities.ShippingCompanyImageFile shippingCompanyImageFile = shippingCompany?.shippingCompanyImageFile.FirstOrDefault(p => p.Id == Guid.Parse(request.ImageId));
            if (shippingCompanyImageFile != null)
            {
                shippingCompany?.shippingCompanyImageFile.Remove(shippingCompanyImageFile);
            }
            await _shippingCompanyWriteRepository.SaveAsync();
            return new();
        }
    }
}
