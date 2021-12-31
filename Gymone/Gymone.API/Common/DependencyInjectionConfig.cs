using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.API.Common
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //services.AddScoped<BookStoreDbContext>();

            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<IBookRepository, BookRepository>();

            //services.AddScoped<ICategoryService, CategoryService>();
            //services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
