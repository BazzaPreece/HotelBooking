using HotelBooking.Data;
using HotelBooking.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// RISK: Connection string stored in appsettings - would be good to have that moved to a secrets manager
// RISK: Not set to change between environments, so could end up pointing to the wrong database when deployed
builder.Services.AddDbContext<HotelBookingContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelBookingConnection")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,  $"{ Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase();

app.Run();
