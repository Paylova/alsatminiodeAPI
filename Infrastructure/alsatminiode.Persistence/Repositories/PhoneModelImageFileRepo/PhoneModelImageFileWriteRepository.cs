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
    internal class PhoneModelImageFileWriteRepository : WriteRepository<PhoneModelImageFile>, IPhoneModelImageFileWriteRepository
    {
        public PhoneModelImageFileWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
