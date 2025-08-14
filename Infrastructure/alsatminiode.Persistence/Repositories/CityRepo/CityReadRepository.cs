using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.CityRepo
{
    public class CityReadRepository : ReadRepository<City>, ICityReadRepository
    {
        public CityReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {

        }

        public async Task<City> GetByNameAsync(string cityName)
        {
            var query = Table.AsQueryable();
            return await query.FirstOrDefaultAsync(data => data.cityName == cityName);
        }
    }
}
