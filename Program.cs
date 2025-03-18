using Adapters.Persistence;
using Core.Services;
using Ports;

var builder = WebApplication.CreateBuilder(args);

// Registrar dependências
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<UserService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hexagonal Architecture Example");
    c.RoutePrefix = "docs";
});

app.UseRouting();
app.MapControllers();

app.Run();
