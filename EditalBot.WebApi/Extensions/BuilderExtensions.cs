using System;
using EditalBot.Aplicacao.Interfaces;
using EditalBot.Aplicacao.Services;

namespace EditalBot.WebApi.Extensions;

public static class BuilderExtensions
{
    public static void AddConfiguration(this WebApplicationBuilder builder)
    {
        Console.WriteLine($"O Enviroment é: {builder.Environment.EnvironmentName}");
        builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
            .AddJsonFile("appsettings.json", true, true)
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
            .AddEnvironmentVariables();
    }

    public static void AddControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
    }

    public static void AddSwaggerGen(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
    }

    public static void AddDependencyInjectionConfiguration(this WebApplicationBuilder builder)
    {
        if (builder.Services == null) throw new ArgumentNullException(nameof(builder.Services));

        builder.Services.AddSingleton<IBotService, BotService>();
        builder.Services.AddScoped<ITelegramService, TelegramService>();
    }
}
