using Microsoft.Extensions.DependencyInjection;
using SevenTiny.Cloud.SSO.Infrastructure.DependencyInjection;
using System.Reflection;

namespace SevenTiny.Cloud.SSO.Core
{
    public static class ServiceInjector
    {
        public static void InjectCore(this IServiceCollection services)
        {
            services.AddScoped(Assembly.GetExecutingAssembly());
        }
    }
}
