using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Actors
{
    public sealed record ActorResponseDto(
        Guid Id,
        string FirstName,
        string LastName,
        string? ImageUrl,
        DateTime? BirthDate,
        string Description,
        bool IsActive = true) : IResponseDto;
}
