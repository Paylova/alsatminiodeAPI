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
    public class PhoneBrandImageFileWriteRepository : WriteRepository<PhoneBrandImageFile>, IPhoneBrandImageFileWriteRepository
    {
        public PhoneBrandImageFileWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
