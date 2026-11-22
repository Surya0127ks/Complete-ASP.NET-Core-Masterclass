var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// UseHttpsRedirection is a middleware that redirects HTTP requests to HTTPS,
// ensuring secure communication between the client and server.
app.UseHttpsRedirection();

// UseAuthorization is a middleware that enables authorization capabilities in the application.
app.UseAuthorization();

// Map controllers used to map the endpoints for the API controllers defined in the application.
// This allows the application to handle incoming HTTP requests and route them to the appropriate
// controller actions based on the defined routes and HTTP methods.
app.MapControllers();

app.Run();
