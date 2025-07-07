﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Mappers.Categories
{
    public sealed class ManuelCategoryMapper : ICategoryMapper
    {
        public Category ConvertToEntity(CategoryAddRequestDto dto)
        {
            return new Category
            {
                Name = dto.Name,
                Description = dto.Description,
            };
        }
        public Category ConverToEntity(CategoryUpdateRequestDto dto)
        {
            return new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                IsActive = dto.IsActive,
                IsDeleted = dto.IsDeleted
            };
        }
        public CategoryResponseDto ConvertToReponse(Category category)

        {
            return new CategoryResponseDto
            {
                Id = category.Id,
                Name = category.Name ?? string.Empty,
                Description = category.Description ?? string.Empty,
            };
        }
        public List<CategoryResponseDto> ConvertToResponseList(List<Category> categories)
        {
            // List<CategoryResponseDto> responseList = new List<CategoryResponseDto>();
            //foreach (var category in categories)
            //{
            //    responseList.Add(ConvertToReponse(category));
            //}
            //return responseList;
            return categories.Select(x => ConvertToReponse(x)).ToList();
        }
    }
}
