using alsatminiode.Application.Repositories.PhoneBrandRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneBrandRepo
{
    public class PhoneBrandReadRepository : ReadRepository<PhoneBrand>, IPhoneBrandReadRepository
    {
        public PhoneBrandReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }

        public async Task<PhoneBrand> GetByNameAsync(string brandName)
        {
            var query = Table.AsQueryable();
            return await query.FirstOrDefaultAsync(data => data.brandName == brandName);
        }
    }
}
