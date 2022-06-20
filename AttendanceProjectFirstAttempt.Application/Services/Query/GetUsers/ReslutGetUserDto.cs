using AttendanceProjectFirstAttempt.Application.Services.Query.GetUsers;
using System.Collections.Generic;

namespace AttendanceProjectFirstAttempt.Application.Services.Query.GetUsers
{
    public class ReslutGetUserDto
    {
        public List<GetUsersDto> Users { get; set; }
        public int Rows { get; set; }
    }
}
