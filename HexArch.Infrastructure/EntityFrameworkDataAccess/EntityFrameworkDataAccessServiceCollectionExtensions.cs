using HexArch.ApplicationCore.Repositories;
using HexArch.Infrastructure.EntityFrameworkDataAccess;
using HexArch.Infrastructure.EntityFrameworkDataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EntityFrameworkDataAccessServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomEntityFrameworkDataAccess(this IServiceCollection services)
        {
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer("Data Source=.;Initial Catalog=Empty;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            });
            services.AddScoped<IStudentReadOnlyRepository, StudentReadOnlyRepository>();

            return services;
        }
    }
}
