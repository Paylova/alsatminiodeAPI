using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.CityRepo
{
    public class CityWriteRepository : WriteRepository<City>, ICityWriteRepository
    {
        readonly ICountryReadRepository _countryReadRepository;

        public CityWriteRepository(alsatminiodeAPIDbContext context, ICountryReadRepository countryReadRepository) : base(context)
        {
            _countryReadRepository = countryReadRepository;
        }

        public async Task SaveByCountryNameAndCityNameAsync(string countryName, string cityName)
        {
            var country = await _countryReadRepository.GetByNameAsync(countryName);
            var city = new City{
                cityName = cityName,
                cityCountry = country,
                cityDistricts = new List<District>()   
            };
            await this.AddAsync(city);
            await this.SaveAsync();


        }
    }
}
