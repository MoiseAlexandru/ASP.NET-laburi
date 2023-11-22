using Lab4.Helper.Seeders;
using Lab4.Repositories.DatabaseRepository;
using Lab4.Services.DemoService;

namespace Lab4.Helper.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            // services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            // services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            // services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDemoService, DemoService>();
            return services;
        }
        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddScoped<StudentSeeder>();
            // services.AddScoped<Model1Seeder>();
            return services;
        }
    }
}
