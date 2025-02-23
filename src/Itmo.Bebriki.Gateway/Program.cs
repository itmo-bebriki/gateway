#pragma warning disable CA1506

using Itmo.Bebriki.Gateway.Presentation.Http.Extensions;
using Itmo.Bebriki.Gateway.Presentation.Http.Middlewares;
using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Observability;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services.AddPlatform();
builder.AddPlatformObservability();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();
builder.Services.ConfigureSwaggerGen(opt => opt.UseOneOfForPolymorphism());

builder.Services.AddGateway();

builder.Services.AddUtcDateTimeProvider();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAnyOrigin",
        policyBuilder =>
        {
            policyBuilder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

WebApplication app = builder.Build();

app.UseCors("AllowAnyOrigin");

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware<GrpcExceptionHandlingMiddleware>();

app.UsePlatformObservability();

app.MapControllers();

await app.RunAsync();
