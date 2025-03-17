using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using apikkkkkkkkkkkkkkkk.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<apikkkkkkkkkkkkkkkkContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("apikkkkkkkkkkkkkkkkContext") ?? throw new InvalidOperationException("Connection string 'apikkkkkkkkkkkkkkkkContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HT request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
