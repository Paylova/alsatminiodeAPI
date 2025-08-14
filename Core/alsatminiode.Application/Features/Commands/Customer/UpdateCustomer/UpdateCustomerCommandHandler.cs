using alsatminiode.Application.Repositories.CustomerRepo;
using alsatminiode.Application.Repositories.PhoneSituationRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        ICustomerReadRepository _customerReadRepository;
        IPhoneSituationReadRepository _phoneSituationReadRepository;
        ICustomerWriteRepository _customerWriteRepository;

        public UpdateCustomerCommandHandler(ICustomerReadRepository customerReadRepository, IPhoneSituationReadRepository phoneSituationReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _phoneSituationReadRepository = phoneSituationReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.id);
            alsatminiode.Domain.Entities.PhoneSituation phoneSituation = await _phoneSituationReadRepository.GetByIdAsync(request.customerPhoneSituation);
            customer.customerPhoneSituation = phoneSituation;
            await _customerWriteRepository.SaveAsync();

            return new()
            {
                customer = customer
            };
        }
    }
}
