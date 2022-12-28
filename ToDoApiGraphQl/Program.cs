using Microsoft.EntityFrameworkCore;
using ToDoApiGraphQl.Data;
using ToDoApiGraphQl.GraphQL;
using ToDoApiGraphQl.GraphQL.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();

builder.Services.AddPooledDbContextFactory<Context>(options =>
{
    var connetionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
});



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
