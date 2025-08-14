using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.ShippingCompany.RemoveShippingCompany
{
    public class RemoveShippingCompanyCommandRequest : IRequest<RemoveShippingCompanyCommandResponse>
    {
        public string id { get; set; }
    }
}
