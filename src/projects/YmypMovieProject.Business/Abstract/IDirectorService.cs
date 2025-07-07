using Core.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract
{
    public interface IDirectorService : IGenericService<Director,DirectorResponseDto,DirectorAddRequestDto,DirectorUpdateRequestDto>,
        IGenericServiceAsync<Director,DirectorResponseDto,DirectorAddRequestDto,DirectorUpdateRequestDto>
    {
        
    }
}
