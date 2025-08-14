using alsatminiode.Application.Repositories.PhoneBrandRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneBrandRepo
{
    public class PhoneBrandWriteRepository : WriteRepository<PhoneBrand>, IPhoneBrandWriteRepository
    {
        public PhoneBrandWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
