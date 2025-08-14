using alsatminiode.Application.Repositories;
using alsatminiode.Application.Repositories.CustomerAnswersRepo;
using alsatminiode.Application.Repositories.CustomerRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.CustomerAnswersRepo
{
    public class CustomerAnswersWriteRepository : WriteRepository<CustomerAnswers>, ICustomerAnswersWriteRepository
    {
        public CustomerAnswersWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {

        }
    }
}
