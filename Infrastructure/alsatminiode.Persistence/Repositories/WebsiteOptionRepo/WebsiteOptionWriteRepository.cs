using alsatminiode.Application.Repositories.WebsiteOptionRepo;
using alsatminiode.Domain.Entities;
using alsatminiode.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Repositories.WebsiteOptionRepo
{
    public class WebsiteOptionWriteRepository : WriteRepository<WebsiteOption>, IWebsiteOptionWriteRepository
    {
        public WebsiteOptionWriteRepository(alsatminiodeAPIDbContext context) : base(context)
        {
        }
    }
}
