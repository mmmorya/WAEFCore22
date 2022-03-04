using Microsoft.AspNetCore.Mvc;
using WAEFCore22.AppCode.BusinessLogic;
using WAEFCore22.AppCode.Interface;
using WAEFCore22.AppCode.Interface.Repos;
using WAEFCore22.Models;

namespace WAEFCore22.Controllers
{
    public class APIController : Controller
    {
        private readonly IStudent_BL _student_BL;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public APIController(IStudent_BL student_BL, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _student_BL = student_BL;
            _unitOfWorkFactory = unitOfWorkFactory;
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


        [HttpGet]
        public IActionResult GetStudentsV2()
        {
            IStudent_GenRP student_GenRP = new Student_GenRP(_unitOfWorkFactory);
            var d = student_GenRP.GetAllStudents();
            return Json(d);
        }

        [HttpPost]
        public IActionResult GetStudentByGRPM(int id)
        {
            IStudent_GenRP student_GenRP = new Student_GenRP(_unitOfWorkFactory);
            var d = student_GenRP.GetAllStudentRP(id);
            return Json(d);
        }
    }
}