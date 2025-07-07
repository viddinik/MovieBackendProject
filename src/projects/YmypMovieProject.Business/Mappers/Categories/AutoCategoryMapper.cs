﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Mappers.Categories
{
    public sealed class AutoCategoryMapper : ICategoryMapper
    {
        private readonly IMapper _mapper;

        public AutoCategoryMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Category ConverToEntity(CategoryUpdateRequestDto dto)
        {
            return _mapper.Map<Category>(dto);
        }

        public Category ConvertToEntity(CategoryAddRequestDto dto)
        {
            return _mapper.Map<Category>(dto);
        }

        public CategoryResponseDto ConvertToReponse(Category category)
        {
            return _mapper.Map<CategoryResponseDto>(category);
        }

        public List<CategoryResponseDto> ConvertToResponseList(List<Category> categories)
        {
            return _mapper.Map<List<CategoryResponseDto>>(categories);
        }
    }
}
