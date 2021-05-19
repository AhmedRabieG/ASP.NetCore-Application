using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config ;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_config.GetConnectionString("EmployeeDBConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
            })
                     .AddEntityFrameworkStores<AppDbContext>();
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy("DeleteRolePolicy",
                        policy => policy.RequireClaim("Delete Role"));
               
                options.AddPolicy("EditRolePolicy",
                                   policy => policy.RequireClaim("Edit Role", "true"));

                options.AddPolicy("AdminRolePolicy",
                   policy => policy.RequireClaim("Admin"));

                //  options.AddPolicy("EditRolePolicy", policy => policy.RequireClaim("Edit Role"));
            });

            

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Administration/AccessDenied");
            });


            
            services.AddMvc(
                     options => options.EnableEndpointRouting = false);

            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "925651397849-ai225llc4votuqdp93mn2oarp1b0833k.apps.googleusercontent.com";
                options.ClientSecret = "B0YyYnmZCDoU7WoxoKk5jZfn";
            })
               .AddFacebook(options =>
                 {
                     options.AppId = "4250937284966375";
                     options.AppSecret = "5253feba4a7588623104839ca786b625";
                 });

            services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseRouting();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
