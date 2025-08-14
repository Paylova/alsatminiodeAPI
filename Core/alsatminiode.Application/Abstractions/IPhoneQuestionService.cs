using alsatminiode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Abstractions
{
    public interface IPhoneQuestionService
    {
        List<PhoneQuestion> GetQuestions();
    }
}
