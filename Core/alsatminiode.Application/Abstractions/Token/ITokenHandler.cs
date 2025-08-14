﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = alsatminiode.Application.DTOs;

namespace alsatminiode.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        F::Token CreateAccessToken(int minute);
    }
}
