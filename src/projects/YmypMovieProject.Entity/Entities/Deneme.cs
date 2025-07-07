using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Entities
{
    public sealed class Deneme : BaseEntity
    {
        public int MyProperty { get; set; }
    }
    public record ProperyRecord
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
    }
    public record ConstructorRecord(int Id, string Name,bool IsActive, DateTime CreateAt);
    public sealed record DirectorDenemeDto (Guid id,string FirstName, string LastName);
}
