using RepositoryPattern.Models;
using System.Net.Cache;

namespace RepositoryPattern.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> getAllStudent()
        {
            return DataSource();
        }

        public Student getStudentById(int id)
        {
            return DataSource().Where(u => u.StudentId == id).FirstOrDefault();
        }

        private List<Student> DataSource() {
            return new List<Student>
            {
                new Student {StudentId = 1, Name = "Hamza", FatherName = "Jalil", Age = 22,},
                new Student {StudentId = 2, Name = "Faryal", FatherName = "Wasim", Age = 21,},
                new Student {StudentId = 3, Name = "Bilal", FatherName = "Zafar", Age = 22,}
            };
        }
    }
}
