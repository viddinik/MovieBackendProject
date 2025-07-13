using Core.Business.Utilites.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete
{
    public class ActorManager : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorManager(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public IDataResult<ICollection<ActorResponseDto>> GetAll(bool deleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ActorResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ActorResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ActorResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IResult Insert(ActorAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(ActorAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Modify(ActorUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task ModifyAsync(ActorUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
