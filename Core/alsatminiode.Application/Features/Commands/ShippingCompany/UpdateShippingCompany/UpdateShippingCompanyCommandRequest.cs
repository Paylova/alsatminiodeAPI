using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompany.UpdateShippingCompany
{
    public class UpdateShippingCompanyCommandRequest : IRequest<UpdateShippingCompanyCommandResponse>
    {
        public string id { get; set; }
        public string companyName { get; set; }
        public string companyDealCode { get; set; }
    }
}
