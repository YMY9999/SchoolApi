using AutoMapper;
using SchoolApi.Core.Features.Students.Queries.Results;
using SchoolApi.Data.Entities;

namespace SchoolApi.Core.Mapping.StudentMapping
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, GetStudentsListResponse>()
                  .ForMember(dest => dest.DepartmentName,
                  opt => opt.MapFrom(src => src.Department.DName));
        }

    }
}
