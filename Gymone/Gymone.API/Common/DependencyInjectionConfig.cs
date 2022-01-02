using Gymone.API.Context;
using Gymone.API.Repository;
using Gymone.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Gymone.API.Common
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddTransient<IDbContextFactory<ApplicationDbContext>, AppDbContextFactory>();
            //services.AddDefaultIdentity<ApplicationWebUser>()
            //        .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders().AddDefaultUI();

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IDapper, Dapperr>();
            services.AddScoped<IAccountData, AccountData>();
            services.AddScoped<IPaymentDetails, PaymentDetails>();
            services.AddScoped<IPaymentlisting, Paymentlisting>();
            services.AddScoped<IPlanMaster, PlanMaster>();
            services.AddScoped<IReceipt, Receipt>();
            services.AddScoped<IRegisterMember, RegisterMember>();
            services.AddScoped<IRenewal, Renewal>();
            services.AddScoped<ISchemeMaster, SchemeMaster>();
            services.AddTransient<IUserRepository<ApplicationWebUser>, UserRepository>();
            return services;
        }
    }
}
