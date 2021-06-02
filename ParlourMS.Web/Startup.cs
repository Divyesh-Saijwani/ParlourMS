using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParlourMS.BL;
using ParlourMS.BL.Extensions;
using ParlourMS.Data;
using ParlourMS.Data.Models;

namespace ParlourMS.Web
{
    public class Startup
    {
        public Startup ( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddParlourMSDataServices ( Configuration.GetConnectionString ( "DefaultConnection" ) );

            services.AddDefaultIdentity<User> ( options => options.SignIn.RequireConfirmedAccount = true )
                .AddEntityFrameworkStores<ApplicationDbContext> ();
            services.AddControllersWithViews ();

            services.AddSmtpConfig ( config =>
            {
                config.Server = "";
                config.Port = 0;
                config.EnableSsl = false;
                config.FromDisplayName = "";
                config.FromAddress = "";
                config.Password = "";
                config.Domain = "";
            } );

            services.AddParlourMSBusinessServices ();
            services.AddRazorPages ();
            services.AddScoped<SignInManager<User>, SignInManager<User>> ();
            services.AddScoped<UserManager<User>, UserManager<User>> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if ( env.IsDevelopment () )
            {
                app.UseDeveloperExceptionPage ();
                app.UseMigrationsEndPoint ();
            }
            else
            {
                app.UseExceptionHandler ( "/Home/Error" );
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }
            app.UseHttpsRedirection ();
            app.UseStaticFiles ();

            app.UseRouting ();

            app.UseAuthentication ();
            app.UseAuthorization ();

            app.UseEndpoints ( endpoints =>
              {
                  endpoints.MapControllerRoute (
                      name: "default",
                      pattern: "{controller=Home}/{action=Index}/{id?}" );
                  endpoints.MapRazorPages ();
              } );
        }
    }
}
