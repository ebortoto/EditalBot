using EditalBot.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddSwaggerGen();
builder.AddControllers();
builder.AddConfiguration();
builder.AddDependencyInjectionConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
