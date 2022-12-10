using Microsoft.EntityFrameworkCore;
using ToDoApiGraphQl.BusinessRules.Validators;
using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.Repositories;
using ToDoApiGraphQl.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddGraphQLServer();
//.AddQueryType<Query>();

builder.Services.AddDbContext<Context>(option => option.UseInMemoryDatabase("TodoDatabase"));

builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ITaskValidator, TaskValidator>();

var app = builder.Build();

/*
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
*/

app.MapGraphQL();

app.Run();
