using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Inventory.Application;
using Restaurant.Inventory.Domain.Repositories;

/*using Restaurant.Inventory.Infrastructure.EF.Contexts;
using Restaurtant.Inventory.Infrastructure.EF;
using Restaurtant.Inventory.Infrastructure.EF.Contexts;
using Restaurtant.Inventory.Infrastructure.EF.Repositories;*/
using Restaurtant.Inventory.Infrastructure.MemoryPersistence;
using System.Reflection;

namespace Restaurtant.Inventory.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
             bool isDevelopment)
        {
            services.AddApplication();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            //AddDatabase(services, configuration, isDevelopment);
            
            AddMemoryDatabase(services);

            return services;
        }

        private static void AddMemoryDatabase(IServiceCollection services)
        {
            MemoryDatabase database = new MemoryDatabase();

            services.AddSingleton(database);


            services.AddScoped<IUnitOfWork, UnitOfWorkMemoryRepository>();
            services.AddScoped<ILugarRepository, LugarMemoryRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioMemoryRepository>();
            services.AddScoped<IReunionRepository, ReunionMemoryRepository>();


        }
        /*

        private static void AddDatabase(IServiceCollection services, IConfiguration configuration, bool isDevelopment)
        {
            var connectionString =
                    configuration.GetConnectionString("InventoryDbConnectionString");
            services.AddDbContext<ReadDbContext>(context =>
                    context.UseSqlServer(connectionString));
            services.AddDbContext<WriteDbContext>(context =>
                context.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ITransaccionRepository, TransaccionRepository>();

            using var scope = services.BuildServiceProvider().CreateScope();
            if (!isDevelopment)
            {
                var context = scope.ServiceProvider.GetRequiredService<ReadDbContext>();
                context.Database.Migrate();
            }
        }*/
    }
}