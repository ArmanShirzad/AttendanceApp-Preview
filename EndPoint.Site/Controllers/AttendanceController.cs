using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       
        public IActionResult EditAttendance()
        {
            return View();
        }
        public IActionResult DeleteAttendance()
        {
            return View();
        }

    }
}
