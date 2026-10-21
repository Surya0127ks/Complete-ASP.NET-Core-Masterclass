
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//Conventional Routing maps Controller and Action names to the URL path.
//The default route is defined as follows:

app.MapControllerRoute (
    name: "default",
    pattern: "{controller=Home}/{action=Name}");

app.Run();
