using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Repositories.DistrictRepo
{
    public interface IDistrictWriteRepository : IWriteRepository<District>
    {
        Task SaveDistrictWithCityAndCountry(string districtName,string cityName, string countryName);
    }
}
