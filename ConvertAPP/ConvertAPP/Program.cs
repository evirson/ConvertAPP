using ConvertAPP.Models.Context;
using ConvertAPP.Services;
using ConvertAPP.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var connection = builder.Configuration["FbConnection:FbConnectionString"];

builder.Services.AddDbContext<FbContext>(options => options.UseFirebird(connection));

builder.Services.AddScoped<ClienteInterface, ClienteService>();
builder.Services.AddScoped<TipoClienteInterface, TipoClienteService>();


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
