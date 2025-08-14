using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.ShippingCompanyRepo
{
    public class ShippingCompanyWriteRepository : WriteRepository<ShippingCompany>, IShippingCompanyWriteRepository
    {
        public ShippingCompanyWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
