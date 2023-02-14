using WebRestApi.Startup;


var builder = WebApplication.CreateBuilder(args);

ConfigurationHelper.Initialize(builder.Configuration);

builder.Services.RegisterServices();

var app = builder.Build();

app.ConfigureSwagger();

app.UseHttpsRedirection();

app
    // .MapUserEndpointsd()
    // .MapDogEndpoints()
    .MapProductEndpoints()
;
app.Run();


