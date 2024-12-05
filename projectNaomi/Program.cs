
using Project.Core.Repositories;
using Project.Core.Service;
using Project.Data;
using Project.Data.Repoitories;
using Project.Service;
using projectNaomi;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IGuideService, GuideService>();
builder.Services.AddScoped<IGuideRepositories, GuideRepositories>();

builder.Services.AddScoped<IRegistersService, RegistersService>();
builder.Services.AddScoped<IRegisterRepositories, RegisterRepositories>();

builder.Services.AddScoped<ITripService, TripService>();
builder.Services.AddScoped<ITripRepositories, TripRepositories>();


builder.Services.AddDbContext<DataContex>();
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
