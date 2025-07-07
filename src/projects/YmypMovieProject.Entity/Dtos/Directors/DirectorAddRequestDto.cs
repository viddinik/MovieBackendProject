using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Directors
{
    public sealed record DirectorAddRequestDto(
        string FirstName,
        string Lastname,
        string ImageUrl,// IFormFile olarak değiştirielecek.
        DateTime BirthDate,
        string Description) : ICreateDto;
}
