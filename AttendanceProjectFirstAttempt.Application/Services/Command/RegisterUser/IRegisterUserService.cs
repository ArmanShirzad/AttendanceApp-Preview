using AttendanceProjectFirstAttempt.Application.Interfaces.Contexts;
using AttendanceProjectFirstAttempt.Common.Dto;
using AttendanceProjectFirstAttempt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceProjectFirstAttempt.Application.Services.Command.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IDataBaseContext _context;

        public RegisterUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request)
        {
            User user = new User()
            {
                FullName = request.FullName,
                Email = request.Email
            };

            List<UserInRole> userInRoles = new List<UserInRole>();
            foreach (var item in request.Roles)
            {
                var roles = _context.Roles.Find(item.Id);
                userInRoles.Add(new UserInRole 
                { 
                    
                    Role = roles,
                    RoleId = roles.Id,
                    User = user,
                    UserId = user.Id
                
                });
            }
            user.UserInRoles = userInRoles;

            _context.Users.Add(user);
            _context.SaveChanges();
            return new ResultDto<ResultRegisterUserDto>
            {
                Data = new ResultRegisterUserDto { UserID = user.Id },
                IsSuccess =true,
                Message = "ثبت نام کاربر با موفقیت انجام شد" 
                
            }; 
        }
    }

    public class ResultRegisterUserDto
    {
        public long UserID { get; set; }
    }
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public List<RolesInRegisterUserDto> Roles { get; set; }
    }
    public class RolesInRegisterUserDto
    {
        public long Id { get; set; }
    }
}
