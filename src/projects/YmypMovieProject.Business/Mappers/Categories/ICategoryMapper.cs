using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Mappers.Categories
{
    public interface ICategoryMapper
    {
        Category ConvertToEntity(CategoryAddRequestDto dto);
        public Category ConverToEntity(CategoryUpdateRequestDto dto);
        public CategoryResponseDto ConvertToReponse(Category category);
        public List<CategoryResponseDto> ConvertToResponseList(List<Category> categories);
    }
}
