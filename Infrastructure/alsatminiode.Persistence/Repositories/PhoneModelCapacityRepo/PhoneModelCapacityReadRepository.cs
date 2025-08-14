using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneModelCapacityRepo
{
    public class PhoneModelCapacityReadRepository : ReadRepository<PhoneModelCapacity>, IPhoneModelCapacityReadRepository
    {
        public PhoneModelCapacityReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
