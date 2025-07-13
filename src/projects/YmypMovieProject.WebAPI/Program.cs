using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Concrete;
using YmypMovieProject.Business.DependencyInjection.AutoFac;
using YmypMovieProject.Business.Mappers.Categories;
using YmypMovieProject.Business.Mappers.Profiles;
using YmypMovieProject.Business.Validators;
using YmypMovieProject.DataAccess.Contexts;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.DataAccess.Repositories.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

// Add services to the container.



builder.Services.AddControllers();  
builder.Services.AddDbContext<MovieDbContext>();

//AutoFac configuration
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutoFacBusinessModule());
});

//builder.Services.AddScoped<ICategoryService, CategoryManager>();
//builder.Services.AddScoped<ICategoryRepository, EfCategoryRepository>();
//builder.Services.AddScoped<IMovieService, MovieManager>();
//builder.Services.AddScoped<IMovieRepository, EfMovieRepository>();
//builder.Services.AddScoped<IDirectorService, DirectorManager>();
//builder.Services.AddScoped<IDirectorRepository, EfDirectorRepository>();

builder.Services.AddScoped<ICategoryMapper, AutoCategoryMapper>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddValidatorsFromAssembly(typeof(CategoryValidator).Assembly);

//builder.Services.AddFluentValidationAutoValidation();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();
