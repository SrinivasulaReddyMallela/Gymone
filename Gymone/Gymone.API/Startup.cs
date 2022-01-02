using Gymone.API.Common;
using Gymone.API.Context;
using Gymone.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;

namespace Gymone.API
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
          
            services.AddControllers();
            var ebEnv =
              Configuration.GetSection("ConnectionStrings")
                  .GetChildren()
                  .Select(pair => new { pair.Key, pair.Value })
                  .ToDictionary(keypair => keypair.Key, keypair => keypair.Value);

            foreach (var keyVal in ebEnv) Environment.SetEnvironmentVariable(keyVal.Key, keyVal.Value);

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server =.; Initial Catalog =GYMONEDBMVC; Persist Security Info =False; User ID =sa; Password =sa@1234; MultipleActiveResultSets =False; Encrypt =True; TrustServerCertificate =True; Connection Timeout =30;"));
            services.ResolveDependencies();
            services.AddIdentity<ApplicationWebUser, Microsoft.AspNetCore.Identity.IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });
            services.AddAntiforgery(options =>
            {
                // Set Cookie properties using CookieBuilder properties†.
                options.FormFieldName = "AntiforgeryFieldname";
                options.HeaderName = "X-CSRF-TOKEN-HEADERNAME";
                options.SuppressXFrameOptionsHeader = false;
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Gymone API",
                    Version = "v1"
                });
            });

            services.AddCors();
            //services.AddMvc();
           
            services.AddDataProtection();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            ILoggerFactory loggerFactory)
        {
           DbInitializer.InitializeDatabase(app);
            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gymone v1");
                    //c.RoutePrefix = string.Empty;
                });

            }
            else if (env.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
                    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Gymone");
                });
            }

            loggerFactory.AddFile("Logs/ErrorLog-{Date}.log");
            //app.UseHttpsRedirection();
            //Middle ware. to Encrypt or decrypt the URL
            //app.UseEncryptDecryptQueryStringsMiddleware();
            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
