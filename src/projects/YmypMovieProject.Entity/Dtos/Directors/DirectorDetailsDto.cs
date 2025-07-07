using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Dtos.Directors
{
    public sealed class DirectorDetailsDto
        (Guid id,
        string firstName,
            string lastName,
            string imageUrl,
            DateTime birthDate,
            string description) : IResponseDto;
}
