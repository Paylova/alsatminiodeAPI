using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneQuestion.GetByIdPhoneQuestion
{
    public class GetByIdPhoneQuestionQueryRequest : IRequest<GetByIdPhoneQuestionQueryResponse>
    {
        public string id { get; set; }
    }
}
