using Core.Entity;

namespace YmypMovieProject.Entity.Dtos.Actors
{
    public sealed record ActorUpdateRequestDto(
        string FirstName,
        string LastName,
        string? ImageUrl,
        DateTime? BirthDate,
        string? Description,
        bool IsActive = true,
        bool IsDeleted = false) : IUpdateDto;
}
