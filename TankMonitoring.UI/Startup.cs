using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TankMonitoring.Data.Models;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using TankMonitoring.Data.Models.ORM.context;

namespace TankMonitoring.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EPDK_TANKContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options=> {
                options.LoginPath = "/login";
                options.AccessDeniedPath = "/denied";
                options.Events = new CookieAuthenticationEvents() {
                OnSigningIn = async context=>
                {
                    var principal = context.Principal;
                    if (principal.HasClaim(c=>c.Type==ClaimTypes.UserData))
                    {
                        if (principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.UserData).Value == "1")
                        {
                            var claimsIdentity = principal.Identity as ClaimsIdentity;
                            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"Admin"));
                        }
                        if (principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.UserData).Value == "0")
                        {
                            var claimsIdentity = principal.Identity as ClaimsIdentity;
                            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                        }

                    }
                    await Task.CompletedTask;
                },
                OnSignedIn = async context=>
                {
                    await Task.CompletedTask;
                },
                OnValidatePrincipal = async context=>
                {
                    await Task.CompletedTask;
                }
                
                
                
                };

            });
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseCookiePolicy();



            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Tank}/{action=Index}/{id?}");
            });

            
        }
    }
}
