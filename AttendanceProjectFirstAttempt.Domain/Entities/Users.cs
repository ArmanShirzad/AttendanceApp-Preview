using AttendanceProjectFirstAttempt.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceProjectFirstAttempt.Domain.Entity
{
    public class User:BaseEntity
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<UserInRole> UserInRoles;

        public bool IsActive { get; set; }


    }
}
