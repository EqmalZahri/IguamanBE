using Iguaman.common;
using Iguaman.Repositories;
using Iguaman.Extensions;
using Iguaman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Converters;


var builder = WebApplication.CreateBuilder(args);

string _appPolicy = "IGuaman";

// Add services to the container.
var appSettings = new AppSettings();
builder.Configuration.Bind(appSettings);

// Configure CORS 
builder.Services.AddCors(
    options => options.AddPolicy(
        _appPolicy,
        builder => builder
            .WithOrigins(
                appSettings.CORS
             )
             .SetIsOriginAllowed(isOriginAllowed: _ => true)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
    )
);

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(appSettings.ConnectionStrings.AppConnection));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<AppSettings>(builder.Configuration);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    dbContext.Database.Migrate();
}

app.UseCors(_appPolicy);
app.UseHsts();
if (app.Environment.EnvironmentName.ToUpper() == "LOCAL" || app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
