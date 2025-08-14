using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModel.GetByIdPhoneModel
{
    public class GetByIdPhoneModelQueryRequest : IRequest<GetByIdPhoneModelQueryResponse>
    {
        public string id { get; set; }
    }
}
