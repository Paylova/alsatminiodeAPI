using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneModelImageFile.GetAllPhoneModelImageFile
{
    public class GetPhoneModelImagesQueryRequest : IRequest<List<GetPhoneModelImagesQueryResponse>>
    {
        public string id { get; set; }
    }
}
