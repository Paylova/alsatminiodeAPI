using alsatminiode.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandResponse
    {
        
        
    }
    public class LoginUserCommandResponseSuccess : LoginUserCommandResponse
    {
        public Token Token { get; set; }
    }
    public class LoginUserCommandResponseError : LoginUserCommandResponse
    {
        public string message { get; set; }
    }
}
