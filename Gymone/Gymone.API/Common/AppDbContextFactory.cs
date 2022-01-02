using Gymone.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Gymone.API.Common
{
    public class AppDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        //private readonly IConfiguration _config;
        //private string Connectionstring = "GymoneDatabase";
        //public AppDbContextFactory(IConfiguration config)
        //{
        //    _config = config;
        //}
        ApplicationDbContext IDbContextFactory<ApplicationDbContext>.GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server =.; Initial Catalog =GYMONEDBMVC; Persist Security Info =False; User ID =sa; Password =sa@1234; MultipleActiveResultSets =False; Encrypt =True; TrustServerCertificate =True; Connection Timeout =30;");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
