using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace Regi.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Authentication()
        {
            return View();
        }

        public IActionResult AccountRegistration()
        {
            ViewBag.SchoolName = "소속 기관 이름";
            ViewBag.DisplayName = "사용자 이름";
            ViewBag.Admission = "2019";
            return View();
        }

        public IActionResult Success()
        {
            ViewBag.DisplayName = "사용자 이름";
            ViewBag.Admission = "입학년도";
            ViewBag.UserPrincipalName = "사용자 계정";
            return View();
        }
    }
}
