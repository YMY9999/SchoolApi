using AutoMapper;
using MediatR;
using SchoolApi.Core.Bases;
using SchoolApi.Core.Features.Students.Queries.Models;
using SchoolApi.Core.Features.Students.Queries.Results;
using SchoolApi.Service.Abstract;

namespace SchoolApi.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : ResponseHandler, IRequestHandler<GetStudentsQuery, Response<List<GetStudentsListResponse>>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<GetStudentsListResponse>>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var StudentLsit = await _studentService.GetStudentsAsync();
            var StudentListMapper = _mapper.Map<List<GetStudentsListResponse>>(StudentLsit);
            return Success(StudentListMapper);
        }
    }
}
