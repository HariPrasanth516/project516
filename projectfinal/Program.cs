using Microsoft.EntityFrameworkCore;
using projectfinal.Controllers.data;
using projectfinal.Controllers.Repository;
using projectfinal.Controllers.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<Applicationdbcontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnect")));
builder.Services.AddScoped<Irepository, Studentrepo>();
builder.Services.AddScoped<Iservice, Studentservice>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
