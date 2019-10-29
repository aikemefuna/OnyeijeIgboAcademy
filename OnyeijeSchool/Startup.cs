using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnyeijeSchool.DbContexts;
using OnyeijeSchool.Models;
using OnyeijeSchool.Security;
using OnyeijeSchool.ViewModel;

namespace OnyeijeSchool
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

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedEmail = true;
                



            }).AddEntityFrameworkStores<OnyeijeContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<OnyeijeContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection")));

            services.AddSession(so =>
            {
                so.IdleTimeout = TimeSpan.FromSeconds(60);
            });
            services.AddMvc(options => {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();

                options.Filters.Add(new AuthorizeFilter(policy));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Administration/AccessDenied");
            });
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("EditRolePolicy", policy => policy.RequireClaim("Edit Role","true"));
            //    options.AddPolicy("DeleteRolePolicy", policy => policy.RequireClaim("Delete Role"));

            //});
            services.AddAuthentication()
                .AddGoogle(options =>
                {
                
                    options.ClientId = "496412588141-p72b4l6bu4ird2dc1m6adbci5hlscced.apps.googleusercontent.com";
                    options.ClientSecret = "iY7Pf2MbQ9_2Cc9OhVxOCj7F";
                });
            services.AddAuthentication()
                .AddFacebook(options =>
                {
                    options.AppId = "2450417391674524";
                    options.AppSecret = "d5994978605459547a9e809bdf01436a";
                });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("EditRolePolicy",
                    policy => policy.RequireClaim("Edit Role"));
                options.AddPolicy("DeleteRolePolicy", policy => policy.RequireClaim("Delete Role"));

            });

            //services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndClaimsHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            CreateRoles(serviceProvider).Wait();
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=HomeAts}/{action=Index}/{id?}");
            });
            //CreateRoles(serviceProvider).Wait();
        }

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //initializing custom roles 
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string[] roleNames = { "GlobalAdmin", "Instructor", "Student" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            //Here you could create a super user who will maintain the web app
            var poweruser = new ApplicationUser
            {

                UserName = Configuration.GetSection("UserSettings")["UserName"],
                Email = Configuration.GetSection("UserSettings")["UserEmail"],

            };
            //Ensure you have these values in your appsettings.json file
            string userPWD = Configuration.GetSection("UserSettings")["UserPassword"];
            var _user = await UserManager.FindByEmailAsync(Configuration.GetSection("UserSettings")["UserEmail"]);

            if (_user == null)
            {
                var createPowerUser = await UserManager.CreateAsync(poweruser, userPWD);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the role
                    await UserManager.AddToRoleAsync(poweruser, "GlobalAdmin");

                }
            }

            var instructoruser = new ApplicationUser
            {

                UserName = Configuration.GetSection("UserSettings")["InstructorName"],
                Email = Configuration.GetSection("UserSettings")["InstructorEmail"],

            };
            //Ensure you have these values in your appsettings.json file
            string instructorPWD = Configuration.GetSection("UserSettings")["InstructorPassword"];
            var _instructor = await UserManager.FindByEmailAsync(Configuration.GetSection("UserSettings")["InstructorEmail"]);

            if (_instructor == null)
            {
                var createinstructorUser = await UserManager.CreateAsync(instructoruser, instructorPWD);
                if (createinstructorUser.Succeeded)
                {
                    //here we tie the new user to the role
                    await UserManager.AddToRoleAsync(instructoruser, "Instructor");

                }
            }

            var studentuser = new ApplicationUser
            {

                UserName = Configuration.GetSection("UserSettings")["StudentName"],
                Email = Configuration.GetSection("UserSettings")["StudentEmail"],

            };
            //Ensure you have these values in your appsettings.json file
            string studentPWD = Configuration.GetSection("UserSettings")["StudentPassword"];
            var _student = await UserManager.FindByEmailAsync(Configuration.GetSection("UserSettings")["StudentEmail"]);

            if (_student == null)
            {
                var createstudentUser = await UserManager.CreateAsync(studentuser, studentPWD);
                if (createstudentUser.Succeeded)
                {
                    //here we tie the new user to the role
                    await UserManager.AddToRoleAsync(studentuser, "Student");

                }
            }

        }
    }
}
