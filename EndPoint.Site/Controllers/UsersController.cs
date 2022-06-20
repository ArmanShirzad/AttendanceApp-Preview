using AttendanceProjectFirstAttempt.Application.Services.Query.GetUsers;
using AttendanceProjectFirstAttempt.Application.Services.Users.Queries.GetRoles;
using AttendanceProjectFirstAttempt.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPoint.Site.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUsersService _usersService;
        private readonly IGetRolesService _roleService;

        public UsersController(IGetUsersService usersService, IGetRolesService roleService)
        {
            _usersService = usersService;
            _roleService = roleService;
        }

     
        
        public IActionResult Index (string SearchKey , int page)
        {
            return View("UserList",_usersService.Execute(new RequestGetUserDto { Page= page , SearchKey = SearchKey} ));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = new SelectList(_roleService.Execute().Data ,"Id","Name");
            return View();
        }        
        public IActionResult Edit()
        {
            return View();
        }      
        public IActionResult Remove()
        {
            return View();
        }
        public IActionResult GetDetails()
        {
            return View();
        }
    }
}
