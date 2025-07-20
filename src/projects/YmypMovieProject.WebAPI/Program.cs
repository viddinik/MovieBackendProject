using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Business.Utilites.Security.JWT;
using Core.Business.Utilites.Security.JWT.Encryptions;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

using Microsoft.IdentityModel.Tokens;
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
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = tokenOptions.Issuer,
        ValidAudience = tokenOptions.Audience,
        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
    };
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
app.UseCors("AllowAllOrigins");
app.UseHttpsRedirection();

app.UseAuthentication(); // giriþ anahtarý 

app.UseAuthorization(); // yetki alaný 

app.MapControllers();

app.Run();
