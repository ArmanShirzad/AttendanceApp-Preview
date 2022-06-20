using System.Collections.Generic;

namespace AttendanceProjectFirstAttempt.Domain.Entity
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; } 

        public ICollection<UserInRole> UserInRoles;

    }
}
