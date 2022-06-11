using Microsoft.Extensions.DependencyInjection;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Services
{
    static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()
            ;
    }
}
