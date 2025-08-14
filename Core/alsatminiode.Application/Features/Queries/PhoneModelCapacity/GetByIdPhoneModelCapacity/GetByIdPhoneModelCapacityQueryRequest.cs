using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetByIdPhoneModelCapacity
{
    public class GetByIdPhoneModelCapacityQueryRequest : IRequest<GetByIdPhoneModelCapacityQueryResponse>
    {
        public string id { get; set; }
    }
}
