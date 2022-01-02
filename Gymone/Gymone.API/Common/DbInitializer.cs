using Gymone.API.Context;
using Gymone.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
namespace Gymone.API.Common
{
    public class DbInitializer
    {
        //private readonly ILogger<DbInitializer> _logger;
        //public DbInitializer(ILogger<DbInitializer> logger)
        //{
        //    _logger = logger;
        //}
        public static void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                try
                {
                    var applicationService = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    var userService =serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationWebUser>>();
                    var roleService = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    applicationService.Database.Migrate();
                    CreateRoles(roleService).Wait();
                    CreateAdminUser(userService).Wait();
                }
                catch (Exception ex)
                {
                    var logger = serviceScope.ServiceProvider.GetRequiredService<ILogger>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
        }

        private static async Task CreateAdminUser(UserManager<ApplicationWebUser> userManager)
        {
            var user = await userManager.FindByEmailAsync("Admin@gmail.com");
            if (user == null)
            {
                var x = await userManager.CreateAsync(new ApplicationWebUser
                {
                    Email = "Admin@gmail.com",
                    PasswordHash = new PasswordHasher<ApplicationWebUser>().HashPassword(user, "Test@1234"),
                    UserName = "Admin@gmail.com",
                    FirstName = "Srinivasula Reddy",
                    LastName = "Mallela",
                    EmailConfirmed = true
                });
                user = await userManager.FindByEmailAsync("Admin@gmail.com");
                await userManager.AddToRoleAsync(user, "Admin");
            }

           


            var user2 = await userManager.FindByEmailAsync("SystemUser@gmail.com");
            if (user2 == null)
            {
                var x2 = await userManager.CreateAsync(new ApplicationWebUser
                {
                    Email = "SystemUser@gmail.com",
                    PasswordHash = new PasswordHasher<ApplicationWebUser>().HashPassword(user, "Test@1234"),
                    UserName = "SystemUser@gmail.com",
                    FirstName = "Srinivasula Reddy",
                    LastName = "Mallela",
                    EmailConfirmed = true
                });
                user2 = await userManager.FindByEmailAsync("SystemUser@gmail.com");
                await userManager.AddToRoleAsync(user2, "SystemUser");
            }
           
        }

        private static async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            //Adding roles
            if (!await roleManager.RoleExistsAsync("SystemUser"))
            {
                await roleManager.CreateAsync(new IdentityRole("SystemUser"));
            }
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
        }
    }
}
