using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Application.Repositories.DistrictRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.DistrictRepo
{
    public class DistrictWriteRepository : WriteRepository<District>, IDistrictWriteRepository
    {
        readonly ICountryReadRepository _countryReadRepository;
        readonly ICityReadRepository _cityReadRepository;
        public DistrictWriteRepository(alsatminiodeAPIDbContext context,ICountryReadRepository countryReadRepository, ICityReadRepository cityReadRepository) : base(context)
        {
            _countryReadRepository = countryReadRepository;
            _cityReadRepository = cityReadRepository;
        }

        public async Task SaveDistrictWithCityAndCountry(string districtName, string cityName, string countryName)
        {
            var country = await _countryReadRepository.GetByNameAsync(countryName);
            var city = await _cityReadRepository.GetByNameAsync(cityName);
            var district = new District
            {
                districtName = districtName,
                districtCity = city,
                districtCountry = country
            };
            await this.AddAsync(district);
            await this.SaveAsync();
        }
    }
}
