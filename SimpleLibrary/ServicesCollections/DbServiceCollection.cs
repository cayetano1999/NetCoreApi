using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SimpleLibrary.ServicesCollections
{
    public static class DbServiceCollection
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlConnection");
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Sql Connection has been provided");

            services.AddDbContext<ApplicationDbConext>(opt =>
            {
                opt.UseSqlServer(connectionString);
            });

            return services;

        }
    }
}
