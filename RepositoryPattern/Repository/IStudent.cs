using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public interface IStudent
    {
        List<Student> getAllStudent();
        Student getStudentById(int id);
    }
}
