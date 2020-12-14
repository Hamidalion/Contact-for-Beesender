using ContactBeesender.BLL.Interfaces;
using ContactBeesender.BLL.Managers;
using ContactBeesender.BLL.Repository;
using ContactBeesender.DAL.Contexts;
using ContactBeesender.DAL.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace ContactBeesender.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration ?? throw new System.ArgumentNullException(nameof(configuration));
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Managers
            services.AddScoped(typeof(IRepositoryManager<>), typeof(RepositoryManager<>));
            services.AddScoped<IAccountManager, AccountManager>();
            //services.AddScoped<ITodoManager, TodoManager>();

            // Database context
            services.AddDbContext<ContactBeesenderContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ContactBeesenderConnection")));

            // Microsoft services
            services.AddMemoryCache();
            services.AddControllersWithViews();
                
                // TODO: Add RazorRuntimeCompilation
                //.AddRazorRuntimeCompilation();

            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "ContactBeesender.Cookie";
                //config.LoginPath = "/Account/SignIn";
            });

            // ASP.NET Core Identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ContactBeesenderContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //// TODO: Add Global Error Handler Middleware
            //app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
