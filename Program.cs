using MetanitExperiments.Extensions;
using MetanitExperiments.Middlewares;
using MetanitExperiments.Services;

var builder = WebApplication.CreateBuilder();

builder.Services.AddSingleton<ICounter, RandomCounter>();
builder.Services.AddSingleton<CounterService>();

var app = builder.Build();

app.UseMiddleware<CounterMiddleware>();

app.Run();