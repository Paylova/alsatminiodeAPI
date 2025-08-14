using alsatminiode.Application.Repositories.PhoneBrandImageFileRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneBrandImageFileRepo
{
    public class PhoneBrandImageFileReadRepository : ReadRepository<PhoneBrandImageFile>, IPhoneBrandImageFileReadRepository
    {
        public PhoneBrandImageFileReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
