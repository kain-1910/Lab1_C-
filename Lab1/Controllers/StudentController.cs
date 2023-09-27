using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
namespace Lab1.Controllers
{
    [Route("/Admin/Student")]
    public class StudentController : Controller
    {
        private List<Student> students = new List<Student>();
        
        public StudentController()
        {
            //Tạo danh sách sinh viên với 4 dữ liệu mẫu
            students = new List<Student>()
{
                new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT,
                Gender = Gender.Male,
                Address = "A1-2018", Email = "nam@g.com" },

                new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
                Gender = Gender.Female,
                Address = "A1-2019", Email = "tu@g.com" },

                new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
                Gender = Gender.Male,
                Address = "A1-2020", Email = "phong@g.com" },

                new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                Gender = Gender.Female,
                Address = "A1-2021", Email = "mai@g.com" }
            };
        }
        [HttpGet("List")]
        public IActionResult Index()
        {
            return View(students);
        }
        [HttpGet("Add")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("/Admin/Student/Add")]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                students.Add(student);  
                return View("Index",students);
            }
            return View(student);
        }
    }
}
