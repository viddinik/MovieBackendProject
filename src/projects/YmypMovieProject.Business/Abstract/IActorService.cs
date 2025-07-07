using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using YmypMovieProject.Entity.Dtos.Actors;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Abstract
{
    public interface IActorService : IGenericService<Actor,ActorResponseDto,ActorAddRequestDto,ActorUpdateRequestDto>,
        IGenericServiceAsync<Actor,ActorResponseDto,ActorAddRequestDto,ActorUpdateRequestDto>

    {
        //List<Actor> GetByFirstName(string firstName);
        //List<Actor> GetByLastName(string lastName);
        //Actor GetByFullName(string firstname, string lastname);
        //List<Actor> GetAllByWithMovie();
    }
}
