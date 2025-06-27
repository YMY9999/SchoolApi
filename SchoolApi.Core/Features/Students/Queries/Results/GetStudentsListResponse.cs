using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Core.Features.Students.Queries.Results
{
    public class GetStudentsListResponse
    {
        [Key]
        public int StudID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? DepartmentName { get; set; }

    }
}
