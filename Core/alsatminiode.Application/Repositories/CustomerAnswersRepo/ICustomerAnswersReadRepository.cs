using alsatminiode.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Repositories.CustomerAnswersRepo
{
    public interface ICustomerAnswersReadRepository : IReadRepository<CustomerAnswers>
    {

    }
}
