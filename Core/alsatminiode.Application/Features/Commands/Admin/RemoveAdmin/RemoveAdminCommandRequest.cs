using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.Admin.RemoveAdmin
{
    public class RemoveAdminCommandRequest : IRequest<RemoveAdminCommandResponse>
    {
        public string id { get; set; }
    }
}
