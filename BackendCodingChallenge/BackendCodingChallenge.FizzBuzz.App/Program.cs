using BackendCodingChallenge.FizzBuzz.Lib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddFizzBuzzServices();

using var host = builder.Build();
using var scope = host.Services.CreateScope();

try
{
    var app = scope.ServiceProvider.GetRequiredService<FizzBuzzApp>();
    app.Run();
}
catch (Exception e)
{
    Console.WriteLine(e);
}