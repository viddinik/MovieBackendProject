using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Directors
{
    public sealed record DirectorUpdateRequestDto(
        Guid Id,
        string FirstName,
        string Lastname,
        string ImageUrl,// IFormFile olarak değiştirielecek.
        DateTime BirthDate,
        string Description,
        bool IsActive = true,
        bool IsDeleted = false) : IUpdateDto;
}
