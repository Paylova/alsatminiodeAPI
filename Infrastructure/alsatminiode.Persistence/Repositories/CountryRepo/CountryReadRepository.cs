using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.CountryRepo
{
    public class CountryReadRepository : ReadRepository<Country>, ICountryReadRepository
    {
        public CountryReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {

        }

        public async Task<Country> GetByNameAsync(string countryName)
        {
            var query = Table.AsQueryable();
            return await query.FirstOrDefaultAsync(data => data.countryName == countryName);
        }
    }
}
