using MediatR;
using SchoolApi.Core.Features.Students.Queries.Models;
using SchoolApi.Data.Entities;
using SchoolApi.Service.Abstract;

namespace SchoolApi.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentsQuery, List<Student>>
    {
        private readonly IStudentService _studentService;
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<List<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsAsync();
        }
    }
}
