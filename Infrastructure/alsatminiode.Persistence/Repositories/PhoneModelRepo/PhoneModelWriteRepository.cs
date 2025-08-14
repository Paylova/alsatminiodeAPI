using alsatminiode.Application.Repositories.PhoneBrandRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.PhoneModelRepo
{
    public class PhoneModelWriteRepository : WriteRepository<PhoneModel>, IPhoneModelWriteRepository
    {
        readonly IPhoneBrandReadRepository _phoneBrandReadRepository;
        public PhoneModelWriteRepository(alsatminiodeAPIDbContext context, IPhoneBrandReadRepository phoneBrandReadRepository) : base(context)
        {
            _phoneBrandReadRepository = phoneBrandReadRepository;   
        }

        public async Task SaveChangesModelBrand(string modelName, int phoneFirstPrice, int phoneLastPrice, string brandName)
        {
            var brand = await _phoneBrandReadRepository.GetByNameAsync(brandName);
            var model = new PhoneModel
            {
                modelName = modelName,
                modelFirstPrice = phoneFirstPrice,
                modelLastPrice = phoneLastPrice,
                modelBrand = brand
            };
            await this.AddAsync(model);
            await this.SaveAsync();
        }
    }
}
