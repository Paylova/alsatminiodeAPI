using alsatminiode.Application.Repositories.PhoneCost;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Persistence.Repositories.PhoneCost
{
    public class PhoneCostWriteRepository : WriteRepository<F::PhoneCost>, IPhoneCostWriteRepository
    {
        readonly IPhoneQuestionReadRepository _phoneQuestionReadRepository;
        readonly IPhoneModelReadRepository _phoneModelReadRepository;
        public PhoneCostWriteRepository(alsatminiodeAPIDbContext context, IPhoneQuestionReadRepository phoneQuestionReadRepository, IPhoneModelReadRepository phoneModelReadRepository) : base(context)
        {
            _phoneQuestionReadRepository = phoneQuestionReadRepository;
            _phoneModelReadRepository = phoneModelReadRepository;
        }

        public async Task saveAll(string questionId, string modelId, int phoneCost)
        {
            var model = await _phoneModelReadRepository.GetByIdAsync(modelId);
            var question = await _phoneQuestionReadRepository.GetByIdAsync(questionId);
            var phoneCosts = new alsatminiode.Domain.Entities.PhoneCost
            {
                phoneQuestion = question,
                phoneModel = model,
                phoneCost = Convert.ToInt16(phoneCost)
            };
            await this.AddAsync(phoneCosts);
            await this.SaveAsync();

        }
    }
}
