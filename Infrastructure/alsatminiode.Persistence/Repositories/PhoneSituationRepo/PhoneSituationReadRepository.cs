using alsatminiode.Application.Repositories.PhoneSituationRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneSituationRepo
{
    public class PhoneSituationReadRepository : ReadRepository<PhoneSituation>, IPhoneSituationReadRepository
    {
        public PhoneSituationReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
