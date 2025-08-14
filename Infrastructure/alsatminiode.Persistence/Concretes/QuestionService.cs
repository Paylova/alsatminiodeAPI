using alsatminiode.Application.Abstractions;
using alsatminiode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Concretes
{
    public class QuestionService : IPhoneQuestionService
    {
        public List<PhoneQuestion> GetQuestions()
            => new()
            {
                new() { Id = Guid.NewGuid(), QuestionText = "Cihazınızın ekranı kırık mı? Eksik piksel var mı?",CreatedDate = DateTime.Now },
            };
    }
}
