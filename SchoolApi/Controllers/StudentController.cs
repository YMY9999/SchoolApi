using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Core.Features.Students.Queries.Models;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetAllStudents")]
        public async Task<IActionResult> GetAllStudents()
        {
            var StudentsList = await _mediator.Send(new GetStudentsQuery());
            return Ok(StudentsList);
        }
    }
}
