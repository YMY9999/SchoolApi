using SchoolApi.Data.Entities;
using SchoolApi.Infrastructure.Abstract;
using SchoolApi.Service.Abstract;

namespace SchoolApi.Service.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;
        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentRepo.GetStudentsAsync();
        }
    }
}
