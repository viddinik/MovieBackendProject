﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Users
{
    public sealed record UserResponseDto(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Status

        ) : IResponseDto;
    
}
