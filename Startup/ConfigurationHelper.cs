namespace WebRestApi.Startup
{
    public static class ConfigurationHelper
    {
        public static IConfiguration? Configuration;
        public static void Initialize(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
    