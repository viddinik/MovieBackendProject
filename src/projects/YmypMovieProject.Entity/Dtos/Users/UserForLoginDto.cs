﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Users
{
    public sealed record UserForLoginDto(
        string Email,
        string Password
        ) : IResponseDto;
    
    
}
