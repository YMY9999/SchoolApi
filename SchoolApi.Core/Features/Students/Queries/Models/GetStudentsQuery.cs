using MediatR;
using SchoolApi.Core.Bases;
using SchoolApi.Core.Features.Students.Queries.Results;

namespace SchoolApi.Core.Features.Students.Queries.Models
{
    public class GetStudentsQuery : IRequest<Response<List<GetStudentsListResponse>>>
    {

    }
}
