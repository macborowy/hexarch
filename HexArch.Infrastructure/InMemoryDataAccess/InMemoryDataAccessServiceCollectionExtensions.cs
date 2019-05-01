using HexArch.ApplicationCore.Repositories;
using HexArch.Infrastructure.InMemoryDataAccess;
using HexArch.Infrastructure.InMemoryDataAccess.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class InMemoryDataAccessServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomInMemoryDataAccess(this IServiceCollection services)
        {
            services.AddSingleton<Context>();
            services.AddScoped<IStudentReadOnlyRepository, StudentReadOnlyRepository>();

            return services;
        }
    }
}
