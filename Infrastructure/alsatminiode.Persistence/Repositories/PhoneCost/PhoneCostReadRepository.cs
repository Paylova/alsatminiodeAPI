using alsatminiode.Application.Repositories;
using alsatminiode.Application.Repositories.PhoneCost;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Persistence.Repositories.PhoneCost
{
    public class PhoneCostReadRepository : ReadRepository<F::PhoneCost>, IPhoneCostReadRepository
    {
        public PhoneCostReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
