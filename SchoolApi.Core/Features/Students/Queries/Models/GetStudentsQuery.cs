using MediatR;
using SchoolApi.Core.Features.Students.Queries.Results;

namespace SchoolApi.Core.Features.Students.Queries.Models
{
    public class GetStudentsQuery : IRequest<List<GetStudentsListResponse>>
    {

    }
}
