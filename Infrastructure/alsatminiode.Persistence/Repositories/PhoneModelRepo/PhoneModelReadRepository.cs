using alsatminiode.Application.Repositories.PhoneModelRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneModelRepo
{
    public class PhoneModelReadRepository : ReadRepository<PhoneModel>, IPhoneModelReadRepository
    {
        public PhoneModelReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
