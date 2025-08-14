using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Repositories.CountryRepo
{
    public interface ICountryReadRepository : IReadRepository<Country>
    {
        Task<Country> GetByNameAsync(string countryName);
    }
}
