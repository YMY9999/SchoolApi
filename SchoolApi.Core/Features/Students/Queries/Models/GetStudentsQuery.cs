using MediatR;
using SchoolApi.Data.Entities;

namespace SchoolApi.Core.Features.Students.Queries.Models
{
    public class GetStudentsQuery : IRequest<List<Student>>
    {

    }
}
