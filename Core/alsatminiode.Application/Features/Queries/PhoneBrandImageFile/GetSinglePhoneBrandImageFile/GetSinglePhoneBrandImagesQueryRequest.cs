using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneBrandImageFile.GetSinglePhoneBrandImageFile
{
    public class GetSinglePhoneBrandImagesQueryRequest : IRequest<GetSinglePhoneBrandImagesQueryResponse>
    {
        public string id { get; set; }
    }
}
