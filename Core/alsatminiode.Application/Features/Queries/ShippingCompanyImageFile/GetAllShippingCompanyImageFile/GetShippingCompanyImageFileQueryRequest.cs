using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.ShippingCompanyImageFile.GetAllShippingCompanyImageFile
{
    public class GetShippingCompanyImageFileQueryRequest : IRequest<List<GetShippingCompanyImageFileQueryResponse>>
    {
        public string id { get; set; }
    }
}
