using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneQuestionRepo
{
    public class PhoneQuestionWriteRepository : WriteRepository<PhoneQuestion>, IPhoneQuestionWriteRepository
    {
        public PhoneQuestionWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
