using Ecommerce.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection DatabaseConfigurations(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("connDb");
            services.AddDbContext<ApplicationDbContext>(
                option=>option.UseSqlServer(connectionString)
                );
          return services;
        }
    }
}
