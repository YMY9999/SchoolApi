using Microsoft.EntityFrameworkCore;
using SchoolApi.Data.Entities;
using SchoolApi.Infrastructure.Abstract;
using SchoolApi.Infrastructure.Context;

namespace SchoolApi.Infrastructure.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppDbContext _Db;
        public StudentRepo(AppDbContext appDbContext)
        {
            _Db = appDbContext;
        }


        public async Task<List<Student>> GetStudentsAsync()
        {
            List<Student> students = await _Db.Students.ToListAsync();
            return students;
        }
    }
}
