using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SchoolApi.Core
{
    public static class ModuelCoreDependecies
    {
        public static IServiceCollection AddCoreDependecies(this IServiceCollection service)
        {
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return service;
        }
    }
}
