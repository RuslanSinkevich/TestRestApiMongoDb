using WebResrApi.Startup;
using WebResrApi.Database;


var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

var app = builder.Build();

MongoDataBase mong = new MongoDataBase();
await mong.CreateDbAsync();

app.ConfigureSwagger();

app.UseHttpsRedirection();

app
    // .MapUserEndpointsd()
    // .MapDogEndpoints()
    .MapProductEndpoints()
;
app.Run();


