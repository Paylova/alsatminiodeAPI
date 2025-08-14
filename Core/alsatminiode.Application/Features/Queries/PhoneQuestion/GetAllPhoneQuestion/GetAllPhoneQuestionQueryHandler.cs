using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Queries.PhoneQuestion.GetAllPhoneQuestion
{
    public class GetAllPhoneQuestionQueryHandler : IRequestHandler<GetAllPhoneQuestionQueryRequest, GetAllPhoneQuestionQueryResponse>
    {
        readonly IPhoneQuestionReadRepository _phoneQuestionReadRepository;
        public GetAllPhoneQuestionQueryHandler(IPhoneQuestionReadRepository phoneQuestionReadRepository)
        {
            _phoneQuestionReadRepository = phoneQuestionReadRepository;
        }
        DateTime CreatedDate = new();
        DateTime UpdatedDate = new();
        public async Task<GetAllPhoneQuestionQueryResponse> Handle(GetAllPhoneQuestionQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _phoneQuestionReadRepository.GetAll(false).Count();
            var phonequestion = _phoneQuestionReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(q => new
            {
                q.Id,
                q.QuestionText,
                CreatedDate = q.CreatedDate.ToShortDateString(),
                UpdatedDate = q.UpdatedDate.ToShortDateString()
            }).ToList();

            return new()
            {
                phonequestion = phonequestion,
                totalCount = totalCount
            };

            
        }

    }
}
