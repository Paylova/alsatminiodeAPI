using alsatminiode.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneQuestion.GetAllPhoneQuestion
{
    public class GetAllPhoneQuestionQueryRequest : Pagination,IRequest<GetAllPhoneQuestionQueryResponse>
    {
    }
}
