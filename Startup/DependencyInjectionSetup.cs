using MongoDB.Driver;

namespace WebRestApi.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            service.AddEndpointsApiExplorer();
            service.AddSwaggerGen();
            service.AddSingleton<IMongoClient, MongoClient>(sp =>
                new MongoClient(ConfigurationHelper.Configuration?.GetSection("DefaultConnection").Value));
            return service;
        }


    }
}
