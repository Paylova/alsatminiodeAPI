using alsatminiode.Application.Repositories.FileRepo;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Persistence.Repositories.FileRepo
{
    public class FileReadRepository : ReadRepository<F::File>, IFileReadRepository
    {
        public FileReadRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
