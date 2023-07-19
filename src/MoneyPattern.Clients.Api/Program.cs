using Microsoft.Data.SqlClient;
using MoneyPattern.Core.Repositories.Contracts;
using MoneyPattern.Core.Services;
using MoneyPattern.Core.Services.Contracts;
using MoneyPattern.Infrastructure.Repositories;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDbConnection>(_ => new SqlConnection(builder.Configuration.GetConnectionString("Invoice")));
builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddTransient<IInvoiceService, InvoiceService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
