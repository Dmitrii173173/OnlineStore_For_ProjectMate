using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Interfaces;
using OnlineShopLib.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesToDB(this IServiceCollection services) => services
            .AddTransient<IRepository<Product>, DbRepository<Product>>()
            .AddTransient<IRepository<ClientStatus>, DbRepository<ClientStatus>>()
            .AddTransient<IRepository<ClientType>, DbRepository<ClientType>>()
            .AddTransient<IRepository<Deal>, DbRepository<Deal>>()
            .AddTransient<IRepository<LicenseType>, DbRepository<LicenseType>>()

            ;
    }
}
