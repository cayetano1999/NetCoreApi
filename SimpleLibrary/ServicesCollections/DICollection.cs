using Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLibrary.ServicesCollections
{
    public static class DICollection
    {
        public static IServiceCollection AddServices (this IServiceCollection services)
        {
            services.AddTransient<IBook, BookService>();
            return services;
        }
    }
}
