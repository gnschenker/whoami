using System.Net;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => $"Hostname: {Dns.GetHostName()}, Version: 1.1");

app.Run();
