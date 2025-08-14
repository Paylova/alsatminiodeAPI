using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Repositories.PhoneModelRepo
{
    public interface IPhoneModelWriteRepository : IWriteRepository<PhoneModel>
    {
        Task SaveChangesModelBrand(string modelName,int phoneFirstPrice,int phoneLastPrice,string brandName);
    }
}
