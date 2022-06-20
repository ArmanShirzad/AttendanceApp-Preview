using AttendanceProjectFirstAttempt.Application.Interfaces.Contexts;
using AttendanceProjectFirstAttempt.Application.Services.Users.Queries.GetUsers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceProjectFirstAttempt.Application.Services.Query.GetUsers
{
    public interface IGetUsersService
    {
        ReslutGetUserDto Execute(RequestGetUserDto request);
    }



}


