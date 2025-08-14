using alsatminiode.Application.Repositories.ShippingCompanyImageFileRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.ShippingCompanyImageFileRepo
{
    public class ShippingCompanyImageFileWriteRepository : WriteRepository<ShippingCompanyImageFile>, IShippingCompanyImageFileWriteRepository
    {
        public ShippingCompanyImageFileWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
