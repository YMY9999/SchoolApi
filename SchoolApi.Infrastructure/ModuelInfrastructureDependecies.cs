using Microsoft.Extensions.DependencyInjection;
using SchoolApi.Infrastructure.Abstract;
using SchoolApi.Infrastructure.Repository;

namespace SchoolApi.Infrastructure
{
    public static class ModuelInfrastructureDependecies
    {
        public static IServiceCollection AddInfrastructureDependecies(this IServiceCollection service)
        {
            service.AddTransient<IStudentRepo, StudentRepo>();
            return service;
        }
    }
}
