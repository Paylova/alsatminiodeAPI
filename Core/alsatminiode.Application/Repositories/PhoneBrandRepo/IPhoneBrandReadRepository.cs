using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Repositories.PhoneBrandRepo
{
    public interface IPhoneBrandReadRepository : IReadRepository<PhoneBrand>
    {
        Task<PhoneBrand> GetByNameAsync(string brandName);
    }
}
