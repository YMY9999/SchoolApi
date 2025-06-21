using Microsoft.Extensions.DependencyInjection;
using SchoolApi.Service.Abstract;
using SchoolApi.Service.Implementation;

namespace SchoolApi.Service
{
    public static class ModuelServiceDependecies
    {
        public static IServiceCollection AddServiceDependecies(this IServiceCollection service)
        {
            service.AddTransient<IStudentService, StudentService>();
            return service;
        }
    }
}
