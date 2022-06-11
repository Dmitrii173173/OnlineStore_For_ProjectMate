using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopLib.Context;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
            .AddDbContext<OnlineShopDataBase>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            })
            .AddTransient<DbInitializer>()
            ;
        
    }
}
