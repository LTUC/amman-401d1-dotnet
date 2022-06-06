using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Models.Interfaces;
using SchoolAPI.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<ApiBehaviorOptions>(opt => opt.SuppressModelStateInvalidFilter = true);

            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //        .AddEntityFrameworkStores<SchoolDbContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>(
                options =>
                {
                    options.Password.RequireDigit = false; // Adding digits to the password is not mandatory
                    options.User.RequireUniqueEmail = true; // make sure the email is unique

                }
                    )
                .AddEntityFrameworkStores<SchoolDbContext>();


            services.AddDbContext<SchoolDbContext>(options =>
      {
          // Our DATABASE_URL from js days
          string connectionString = Configuration.GetConnectionString("DefaultConnection");
          options.UseSqlServer(connectionString);
      });

            services.AddTransient<IStudent, StudentService>();
            services.AddTransient<ICourse, CourseService>();
            services.AddTransient<ITechnology, TechnologyService>();
            services.AddTransient<IUserService, UserService>();
            services.AddScoped<JwtTokenService>();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                // Tell the authenticaion scheme "how/where" to validate the token + secret
                options.TokenValidationParameters = JwtTokenService.GetValidationParameters(Configuration);
             });

            services.AddControllers().AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
      );

            services.AddAuthorization(options =>
            {
                options.AddPolicy("create", policy => policy.RequireClaim("persmissions", "create"));
                options.AddPolicy("update", policy => policy.RequireClaim("persmissions", "update"));
                options.AddPolicy("delete", policy => policy.RequireClaim("persmissions", "delete"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            #region check user
            //app.Use(async (context, next) =>
            //{
            //    // url: https://localhost:44387/?name=fadi
            //    // check if there is a user query with Fadi value,  
            //    var remoteIpAddress = context.Request.HttpContext.Connection.RemoteIpAddress.ToString();
            //    string user = context.Request.Query["user"];

            //    if (user == "Fadi")
            //    {
            //        // grading Fadi
            //        //await context.Response.WriteAsync(" -----> Welcome Fadi \n");
            //        await next(); // go to the next middleware

            //    }
            //    else
            //    {
            //        // Tell that you should be login, then dont go to the next middleware
            //        await context.Response.WriteAsync(" -----> You should be Fadi to continue \n");
            //    }
            //});
            #endregion

            #region multiple pipelines
            //app.Use(async (request, next) =>
            //{
            //    await request.Response.WriteAsync("------> 1 st middleware start.\n");
            //    await next();
            //    await request.Response.WriteAsync("------> 1 sd middleware end.\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("------> 2 nd middleware start.\n");
            //    await next();
            //    await context.Response.WriteAsync("------> 2 nd middleware end.\n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("final");
            //});

            // This middleware does not have a "next", so any middleware after this one won't fire if you uncommit this middleware
            // app.Run(async context => await context.Response.WriteAsync(" -----> End \n"));
            #endregion

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
              {

                  endpoints.MapControllers();

                  endpoints.MapGet("/", async context =>
                        {
                            await context.Response.WriteAsync("Hello World! \n");
                        });
              });


        }
    }
}
