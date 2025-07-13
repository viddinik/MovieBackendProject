using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concrete
{
    public class User : BaseEntity
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string? Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string? Status { get; set; }

    }
}
