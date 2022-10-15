using GameServer.Models;
using GameServer.Models.MongoDB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUnitOfWork>(_ => new UnitOfWork(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();