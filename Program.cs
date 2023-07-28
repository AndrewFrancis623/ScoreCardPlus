using Microsoft.OpenApi.Models;
using ScoreCardPlus;
using System.Reflection;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.3",
        Title = "ScoreCard Plus API",
        Description = "An ASP.NET Core Web API for managing Golf Course Scorecards",
        TermsOfService = new Uri("https://example.com/terms"),
        
    });

});
builder.Services.AddDbContext<ScoreCardDBContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
