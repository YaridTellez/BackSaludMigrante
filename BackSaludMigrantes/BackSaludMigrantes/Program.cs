using BackSaludMigrantes.Models.Context;
using Microsoft.EntityFrameworkCore;
using System.Net;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{

    options.UseSqlServer("Server=mssqlsaludmigrantes,1433;Database=SaludMigrantesDB;ConnectRetryCount=0;User Id=sa;Password=Soaint2022*;MultipleActiveResultSets=true");
    //options.UseSqlServer("Server={{DB_ENDPOINT}};Database=SaludMigrantesDB;ConnectRetryCount=0;User Id=sa;Password=Soaint2022*;MultipleActiveResultSets=true");
});

builder.Services.AddCors(options => options.AddPolicy(name: "default",
    policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    }));

/*
if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddHttpsRedirection(options =>
    {
        options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
        options.HttpsPort = 443;
    });
}  */  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("default");
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

