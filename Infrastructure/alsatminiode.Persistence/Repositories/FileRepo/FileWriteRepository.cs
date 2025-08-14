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
    public class FileWriteRepository : WriteRepository<F::File>, IFileWriteRepository
    {
        public FileWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
