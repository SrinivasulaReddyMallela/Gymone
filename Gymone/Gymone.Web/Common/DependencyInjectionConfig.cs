using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.Web.Common
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<IDapper, Dapperr>();
            //services.AddScoped<IAccountData, AccountData>();
            //services.AddScoped<IPaymentDetails, PaymentDetails>();
            //services.AddScoped<IPaymentlisting, Paymentlisting>();
            //services.AddScoped<IPlanMaster, PlanMaster>();
            //services.AddScoped<IReceipt, Receipt>();
            //services.AddScoped<IRegisterMember, RegisterMember>();
            //services.AddScoped<IRenewal, Renewal>();
            //services.AddScoped<ISchemeMaster, SchemeMaster>();
            return services;
        }
    }
}
