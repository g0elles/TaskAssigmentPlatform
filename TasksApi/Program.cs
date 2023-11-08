using Microsoft.EntityFrameworkCore;
using Models.Models;
using Services.Interfaces;
using Services.Repository.UnitOfWork;
using Services.Services;
using Services.Mappers;
using NLog;
using Services.Contracts;
using Services.LoggerService;
using Services.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));


builder.Services.AddControllers();
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TeamTaskTrackerDbContext>(options =>
options.UseSqlServer(builder.Configuration["ConnectionStrings:TeamTask"]));
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddScoped<IProjectAssigmentService, ProjectAssigmentService>();
builder.Services.AddScoped<ITeamMemberService, TeamMemberService>();
builder.Services.AddScoped<IProjectService, ProjectService>();


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

app.UseMiddleware<ExceptionMiddleware>();

app.Run();
