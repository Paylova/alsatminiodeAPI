using alsatminiode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Repositories.CityRepo
{
    public interface ICityReadRepository : IReadRepository<City>
    {
        Task<City> GetByNameAsync(string cityName);
    }
}
