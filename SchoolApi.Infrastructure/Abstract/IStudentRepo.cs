using SchoolApi.Data.Entities;

namespace SchoolApi.Infrastructure.Abstract
{
    public interface IStudentRepo
    {
        public Task<List<Student>> GetStudentsAsync();

    }
}
