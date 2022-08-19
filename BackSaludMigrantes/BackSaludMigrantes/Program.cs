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

    var connectionString = builder.Configuration.GetConnectionString("Connection")
        .Replace("{{DB_ENDPOINT}}",builder.Configuration.GetValue<string>("DB_ENDPOINT"))
        .Replace("{{DB_PORT}}",builder.Configuration.GetValue<string>("DB_PORT"))
        .Replace("{{DB_NAME}}",builder.Configuration.GetValue<string>("DB_NAME"))
        .Replace("{{DB_USER}}",builder.Configuration.GetValue<string>("DB_USER"))
        .Replace("{{DB_PASSWORD}}",builder.Configuration.GetValue<string>("DB_PASSWORD"));
    options.UseSqlServer(connectionString);
    //options.UseSqlServer("Server=localhost,1433;Database=SaludMigrantesDB;ConnectRetryCount=0;User Id=sa;Password=Soaint2022*;MultipleActiveResultSets=true");
});

builder.Services.AddCors(options => options.AddPolicy(name: "default",
    policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    }));

//Requiere certificado SSL en Production
if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddHttpsRedirection(options =>
    {
        options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
        options.HttpsPort = 443;
    });
}   

var app = builder.Build();

using (var scope =app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    if (builder.Configuration.GetValue<bool>("DB_MIGRATE") == true)                    
        context.Database.Migrate();    
    
}
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

