using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineShopping.WebAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OnlineShoppingWebAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineShoppingWebAPIContext") ?? throw new InvalidOperationException("Connection string 'OnlineShoppingWebAPIContext' not found.")));

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
