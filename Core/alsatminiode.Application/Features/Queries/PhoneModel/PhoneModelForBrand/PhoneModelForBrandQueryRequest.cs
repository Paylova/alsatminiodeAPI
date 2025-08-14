using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModel.PhoneModelForBrand
{
    public class PhoneModelForBrandQueryRequest : IRequest<PhoneModelForBrandQueryResponse>
    {
        public string id { get; set; }
    }
}
