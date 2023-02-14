

using Models;

namespace WebRestApi.Startup
{
    public static class MapEndpoints
    {
        //
        // public static WebApplication MapUserEndpointsd(this WebApplication app)
        // {
        //     app.MapGet("/", () => "Hello User");
        //     app.MapGet("/User/{name}", (string name) => $"Hello {name}");    
        //     return app;
        // }
        //
        // public static WebApplication MapDogEndpoints(this WebApplication app)
        // {
        //     app.MapGet("/Dog", () => "Hello boy");
        //     app.MapGet("/Dog/{name}", (string name) => $"Dog {name}");
        //     return app;
        // }

        public static WebApplication MapProductEndpoints(this WebApplication app)
        {
            var user = new List<Product>()
            {
                new Product {  Name = "mik" }
            };
            app.MapGet("/Product", () => Results.Json(user));
            return app;
        }
    }
}
