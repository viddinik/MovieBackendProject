﻿using Autofac;
using Core.Business.Utilites.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Concrete;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.DataAccess.Repositories.Concrete.EntityFramework;

namespace YmypMovieProject.Business.DependencyInjection.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder) 
        {
            builder.RegisterType<MovieManager>().As<IMovieService>();
            builder.RegisterType<EfMovieRepository>().As<IMovieRepository>();
            builder.RegisterType<DirectorManager>().As<IDirectorService>();
            builder.RegisterType<EfDirectorRepository>().As<IDirectorRepository>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>(); 
            builder.RegisterType<ActorManager>().As<IActorService>();
            builder.RegisterType<EfActorRepository>().As<IActorRepository>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserRepository>().As<IUserRepository>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
