using Core.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category,CategoryResponseDto,CategoryAddRequestDto,CategoryUpdateRequestDto>,
       IGenericServiceAsync<Category,CategoryResponseDto,CategoryAddRequestDto,CategoryUpdateRequestDto>
    {
        
    }
}
