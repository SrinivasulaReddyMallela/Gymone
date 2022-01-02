using System;
using Gymone.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationWebUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<ApplicationWebUser>(b =>
            //{
            //    b.HasKey(e => e.TempUserID);
            //    b.Property(e => e.TempUserID).ValueGeneratedOnAdd();
            //});
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        //private readonly IConfiguration _config;
        //private string Connectionstring = "GymoneDatabase";
        //public ApplicationDbContextFactory(IConfiguration config)
        //{
        //    _config = config;
        //}
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server =.; Initial Catalog =GYMONEDBMVC; Persist Security Info =False; User ID =sa; Password =sa@1234; MultipleActiveResultSets =False; Encrypt =True; TrustServerCertificate =True; Connection Timeout =30;");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
