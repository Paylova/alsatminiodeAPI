using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.CountryRepo
{
    public class CountryWriteRepository : WriteRepository<Country>, ICountryWriteRepository
    {
        public CountryWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
