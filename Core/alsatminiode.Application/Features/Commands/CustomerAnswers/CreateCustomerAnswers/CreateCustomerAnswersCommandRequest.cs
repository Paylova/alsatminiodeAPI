using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Features.Commands.CustomerAnswers.CreateCustomerAnswers
{
    public class CreateCustomerAnswersCommandRequest : IRequest<CreateCustomerAnswersCommandResponse>
    {
        public string customerId { get; set; }
        public List<F::PhoneCost> phoneCost { get; set; }
    }
}
