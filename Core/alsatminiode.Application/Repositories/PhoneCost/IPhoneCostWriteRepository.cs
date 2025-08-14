using alsatminiode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Repositories.PhoneCost
{
    public interface IPhoneCostWriteRepository : IWriteRepository<F::PhoneCost>
    {
        Task saveAll(string questionId, string modelId,int phoneCost);
    }
}
