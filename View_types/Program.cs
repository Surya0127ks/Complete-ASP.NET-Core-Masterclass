//building a web application using ASP.NET Core 8.0 with C# 12.0 features.

var builder = WebApplication.CreateBuilder(args);

// register the services required for the application
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

//build the application and configure the HTTP request pipeline.
var app = builder.Build();

//MapControllerRoute is used to define a route for the controllers in the application.
//It specifies the default route pattern for incoming requests.
app.MapControllerRoute(  
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//terminate the application and start listening for incoming HTTP requests.
app.Run();
