using alsatminiode.Application.Repositories.PhoneModelImageRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneModelImageFileRepo
{
    internal class PhoneModelImageFileReadRepository : ReadRepository<PhoneModelImageFile>, IPhoneModelImageFileReadRepository
    {
        public PhoneModelImageFileReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
