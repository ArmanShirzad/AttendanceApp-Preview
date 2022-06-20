using AttendanceProjectFirstAttempt.Application.Interfaces.Contexts;
using AttendanceProjectFirstAttempt.Application.Services.Query.GetUsers;
using AttendanceProjectFirstAttempt.Application.Services.Users.Queries.GetUsers;
using AttendanceProjectFirstAttempt.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceProjectFirstAttempt.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDataBaseContext _context;
        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }


        public ReslutGetUserDto Execute(RequestGetUserDto request )
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }
            int rowscount = 0;
            var usersList = users.ToPaged(request.Page,20,out rowscount) .Select(p => new GetUsersDto
            {
                Email = p.Email,
                FullName = p.FullName,
                Id = p.Id,
            }).ToList();

            return new ReslutGetUserDto {Rows =rowscount , Users = usersList  };

        }

 
    }
}
