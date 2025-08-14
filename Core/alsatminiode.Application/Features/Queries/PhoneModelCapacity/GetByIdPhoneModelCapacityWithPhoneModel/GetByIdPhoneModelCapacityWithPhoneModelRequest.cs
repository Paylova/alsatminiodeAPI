using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelCapacity.GetByIdPhoneModelCapacityWithPhoneModel
{
    public class GetByIdPhoneModelCapacityWithPhoneModelRequest : IRequest<GetByIdPhoneModelCapacityWithPhoneModelResponse>
    {
        public string id { get; set; }
    }
}
