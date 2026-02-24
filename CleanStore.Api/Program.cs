using CleanStore.Application;
using CleanStore.Infrastructure;
using CleanStore.Infrastructure.SharedContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";
builder.Services.AddDbContext<AppDbContext>(x =>
    x.UseSqlServer(connectionString, m => m.MigrationsAssembly("CleanStore.Api")));
builder.Services.AddApplication();
builder.Services.AddInfrastructure();


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.MapPost("/v1/accounts", async (


ISender sender,
CleanStore.Application.AccountContext.UseCases.Create.Command command) =>

{
    var result = await sender.Send(command);
    return TypedResults.Created($"v1/accounts/{result.Value.Id}", result);

});

app.Run();
