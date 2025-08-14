using alsatminiode.Application.Repositories.CustomerAnswersRepo;
using alsatminiode.Application.Repositories.CustomerRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.CustomerAnswers.CreateCustomerAnswers
{
    public class CreateCustomerAnswersCommandHandler : IRequestHandler<CreateCustomerAnswersCommandRequest, CreateCustomerAnswersCommandResponse>
    {
        readonly ICustomerAnswersWriteRepository _customerAnswersWriteRepository;
        readonly ICustomerReadRepository _customerReadRepository;

        public CreateCustomerAnswersCommandHandler(ICustomerAnswersWriteRepository customerAnswersWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerAnswersWriteRepository = customerAnswersWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<CreateCustomerAnswersCommandResponse> Handle(CreateCustomerAnswersCommandRequest request, CancellationToken cancellationToken)
        {
            alsatminiode.Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.customerId);
            foreach (var soru in request.phoneCost)
            {
                await _customerAnswersWriteRepository.AddAsync(new()
                {
                    customer = customer,
                    phoneCost = soru
                });
            }

            return new();

        }
    }
}
