using AutoMapper;
using Core.Business.Utilites.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Constants;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Directors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete
{
    public sealed class DirectorManager : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly IMapper _mapper;
        public DirectorManager(IDirectorRepository directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }

        public IDataResult<ICollection<DirectorResponseDto>> GetAll(bool deleted)
        {
            try
            {
                var directors = _directorRepository.GetAll(d => d.IsDeleted == deleted);
                if (directors is null || !directors.Any())
                {
                    return new ErrorDataResult<ICollection<DirectorResponseDto>>(ResultMessages.ErrorListed);
                }
                var directorDtos = _mapper.Map<ICollection<DirectorResponseDto>>(directors);
                return new SuccessDataResult<ICollection<DirectorResponseDto>>(directorDtos, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ICollection<DirectorResponseDto>>($"error! {e.Message}");
                
            }
        }

        public Task<ICollection<DirectorResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<DirectorDetailsDto>> GetAllFullInfo()
        {
            try
            {
                var directors = _directorRepository.GetQueryable().Include(d => d.Movies).ThenInclude(m => m.Actors).ToList();
                if (directors is null)
                {
                    return new ErrorDataResult<List<DirectorDetailsDto>>(ResultMessages.ErrorListed); 
                }
                var diretorsDto = _mapper.Map<List<DirectorDetailsDto>>(directors);
                return new SuccessDataResult<List<DirectorDetailsDto>>(diretorsDto,ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<DirectorDetailsDto>>($"error! {e.Message}");

            }
        }

        //public IDataResult<ICollection<DirectorResponseDto>> GetAllDeleted()
        //{
        //    try
        //    {
        //        var directors = _directorRepository.GetAll(d => d.IsDeleted);
        //        if (directors is null || !directors.Any())
        //        {
        //            return new ErrorDataResult<ICollection<DirectorResponseDto>>(ResultMessages.ErrorListed);
        //        }
        //        var directorDtos = _mapper.Map<ICollection<DirectorResponseDto>>(directors);
        //        return new SuccessDataResult<ICollection<DirectorResponseDto>>(directorDtos, ResultMessages.SuccessListed);
        //    }
        //    catch (Exception e)
        //    {
        //        return new ErrorDataResult<ICollection<DirectorResponseDto>>($"error! {e.Message}");

        //    }
        //}

        public IDataResult<DirectorResponseDto> GetById(Guid id)
        {
            try
            {
                var director = _directorRepository.Get(d => d.Id == id);
                if (director is null)
                {
                    return new ErrorDataResult<DirectorResponseDto>(ResultMessages.ErrorGetById);
                }
                var dto = _mapper.Map<DirectorResponseDto>(director);
                return new SuccessDataResult<DirectorResponseDto>(dto, ResultMessages.SuccessGetById);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<DirectorResponseDto>($"error!{e.Message}");
            }
        }

        public Task<DirectorResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IResult Insert(DirectorAddRequestDto dto)
        {
            try
            {
                var director = _mapper.Map<Director>(dto);
                _directorRepository.Add(director);
                return new SuccessResult(ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<DirectorResponseDto>($"error!{e.Message}");
            }
        }

        public Task InsertAsync(DirectorAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Modify(DirectorUpdateRequestDto dto)
        {
            try
            {
                var director = _mapper.Map<Director>(dto);
                director.UpdateAt = DateTime.Now;
                _directorRepository.Update(director);
                return new SuccessResult(ResultMessages.SuccessUpdated);
            }
            catch (Exception e)
            {

                return new ErrorResult($"error!{e.Message}");

            }
        }

        public Task ModifyAsync(DirectorUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Guid id)
        {
            try
            {
                var director = _directorRepository.Get(d => d.Id == id);
                if (director is null)
                {
                    return new ErrorResult(ResultMessages.ErrorGetById);
                }
                director.IsDeleted = true;
                director.IsActive = false;
                director.UpdateAt = DateTime.Now;
                _directorRepository.Update(director);
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {

                return new ErrorResult($"error!{e.Message}");
            }
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
