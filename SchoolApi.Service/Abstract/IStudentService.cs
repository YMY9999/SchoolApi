using SchoolApi.Data.Entities;

namespace SchoolApi.Service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
