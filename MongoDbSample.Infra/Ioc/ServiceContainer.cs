using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDbSample.Infra.Repositories;

namespace MongoDbSample.Infra.Ioc
{
    public static class ServiceContainer
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddSingleton(s => s.GetRequiredService<IMongoClient>().GetDatabase("SampleDb"));

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
