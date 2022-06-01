using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Repository;
using test.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPropetarioRepository, PropetarioRepository>();
builder.Services.AddScoped<IPropetarioService, PropetarioService>();

builder.Services.AddDbContext<DbContextPropiedad>
    (op => op.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
                builder => builder.AllowAnyOrigin()));

var port = Environment.GetEnvironmentVariable("PORT");
builder.WebHost.UseUrls("http://*:" + port);

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowWebApp");


app.UseAuthorization();

app.MapControllers();

app.Run();
