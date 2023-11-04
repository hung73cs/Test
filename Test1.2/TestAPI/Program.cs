using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Configuration.AddEnvironmentVariables(prefix: "DictionaryApi");

builder.Services.AddHttpClient();

builder.Services.AddControllers(); 

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
