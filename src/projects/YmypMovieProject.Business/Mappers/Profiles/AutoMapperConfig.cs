﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Dtos.Movies;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Mappers.Profiles
{
    public sealed class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            // mapping configurations for category entity and DTOs
            CreateMap<Category, CategoryResponseDto>();
            CreateMap<CategoryAddRequestDto, Category>();
            CreateMap<CategoryUpdateRequestDto, Category>();
            
            // mapping configurations for director entity and DTOs

            CreateMap<Director, DirectorResponseDto>();
            CreateMap<DirectorAddRequestDto, Director>();
            CreateMap<DirectorUpdateRequestDto, Director>();
            CreateMap<Director, DirectorDetailsDto>();

            // mapping configurations for movie entity and DTOs

            CreateMap<Movie, MovieResponseDto>();
            CreateMap<MovieAddRequestDto, Movie>();
            CreateMap<MovieUpdateRequestDto, Movie>();
            CreateMap<Movie, MovieDetailDto>().ForMember(m => m.Players, option =>
                option.MapFrom(m => m.Actors.Select(a => $"{a.FirstName} {a.LastName}").ToHashSet()));
        }
    }
}
