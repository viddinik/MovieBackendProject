﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Users
{
    public sealed record UserForRegisterDto(
        string FirstName,
        string LastName,
        string Email,
        string Password
        ) : ICreateDto;
    
    
}
