using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;
using System.Collections.Generic;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentRepository _studentRepository;

        public HomeController()
        {
            _studentRepository = new StudentRepository();
        }

        public IActionResult Index()
        {
            //Employee employee = new Employee()
            //{
            //    EmpId = 1,
            //    EmpName = "Test",
            //    Salary = 80000
            //};

            var employee = new List<Employee>()
            {
                new Employee {EmpId = 1, EmpName = "Hamza", Salary = 80000},
                new Employee {EmpId = 2, EmpName = "Faryal", Salary = 60000},
                new Employee {EmpId = 3, EmpName = "Bilal", Salary = 50000},
            };

            ViewBag.data = employee;

            return View();
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.getAllStudent();
        }
        public Student GetOneStudent(int id)
        {
            return _studentRepository.getStudentById(id);
        }
    } 
}

