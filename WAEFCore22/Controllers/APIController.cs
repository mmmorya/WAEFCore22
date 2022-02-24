using Microsoft.AspNetCore.Mvc;
using WAEFCore22.AppCode.Interface;
using WAEFCore22.Models;

namespace WAEFCore22.Controllers
{
    public class APIController : Controller
    {
        private readonly IStudent_BL _student_BL;
        public APIController(IStudent_BL student_BL)
        {
            _student_BL = student_BL;
        }
        public IActionResult GetData()
        {
            var d = new DemoTest {
                Id = 1,
                Name = "D 1"
            };
            return Json(d);
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            var d = _student_BL.GetAllStudents();
            return Json(d);
        }

        [HttpPost]
        public IActionResult GetStudents(int id)
        {
            var d = _student_BL.GetStudent(id);
            return Json(d);
        }
    }
}