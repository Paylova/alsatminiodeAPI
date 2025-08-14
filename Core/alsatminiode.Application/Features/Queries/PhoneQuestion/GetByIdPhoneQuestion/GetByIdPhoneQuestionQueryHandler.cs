using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Features.Queries.PhoneQuestion.GetByIdPhoneQuestion
{
    public class GetByIdPhoneQuestionQueryHandler : IRequestHandler<GetByIdPhoneQuestionQueryRequest, GetByIdPhoneQuestionQueryResponse>
    {
        readonly IPhoneQuestionReadRepository _phoneQuestionReadRepository;

        public GetByIdPhoneQuestionQueryHandler(IPhoneQuestionReadRepository phoneQuestionReadRepository)
        {
            _phoneQuestionReadRepository = phoneQuestionReadRepository;
        }

        public async Task<GetByIdPhoneQuestionQueryResponse> Handle(GetByIdPhoneQuestionQueryRequest request, CancellationToken cancellationToken)
        {
            var phoneQuestion = _phoneQuestionReadRepository.GetWhere(c => c.Id == Guid.Parse(request.id)).Select(c => new
            {
                c.Id,
                c.QuestionText,
            });
            return new()
            {
                phoneQuestion = phoneQuestion,
            };
        }
    }
}
