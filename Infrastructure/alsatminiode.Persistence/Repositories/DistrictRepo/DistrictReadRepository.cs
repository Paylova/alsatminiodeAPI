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
    public class DistrictReadRepository : ReadRepository<District>, IDistrictReadRepository
    {
        public DistrictReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
