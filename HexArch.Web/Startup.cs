using HexArch.ApplicationCore.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HexArch.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureCommonServices(services);

            services.AddDbContext<Infrastructure.EntityFrameworkDataAccess.Context>(options =>
            {
                options.UseSqlServer("Data Source=.;Initial Catalog=Empty;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            });
            services.AddScoped<IStudentReadOnlyRepository, Infrastructure.EntityFrameworkDataAccess.Repositories.StudentReadOnlyRepository>();
        }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            ConfigureCommonServices(services);

            services.AddSingleton<Infrastructure.InMemoryDataAccess.Context>();
            services.AddScoped<IStudentReadOnlyRepository, Infrastructure.InMemoryDataAccess.Repositories.StudentReadOnlyRepository>();
        }

        public void ConfigureCommonServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
