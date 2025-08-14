using alsatminiode.Application.Repositories.AdminRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.AdminRepo
{
    public class AdminWriteRepository : WriteRepository<Admin>, IAdminWriteRepository
    {
        public AdminWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {

        }
    }
}
