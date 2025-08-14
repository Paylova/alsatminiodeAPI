using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompany.CreateShippingCompany
{
    public class CreateShippingCompanyCommandRequest : IRequest<CreateShippingCompanyCommandResponse>
    {
        public string companyName { get; set; }
        public string companyDealCode { get; set; }
    }
}
