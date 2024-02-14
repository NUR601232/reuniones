using Microsoft.Extensions.DependencyInjection;
using Restaurant.Inventory.Domain.Factories;
using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Application
{
    public static class Extensions
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddSingleton<ILugarFactory, LugarFactory>();
            services.AddSingleton<IUsuarioFactory, UsuarioFactory>();
            services.AddSingleton<IReunionFactory, ReunionFactory>();

            
            return services;
        }
    }
}
