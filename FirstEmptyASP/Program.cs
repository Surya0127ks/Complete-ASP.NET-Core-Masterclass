var builder = WebApplication.CreateBuilder(args); //builder use to create initial configuration and services for the application
var app = builder.Build(); // application builder is used to configure the request pipeline and build the application


app.Use((context, next) =>
{
    context.Response.WriteAsync("Response from use1 middleware\n");
    return next();  //pass control to the next middleware in the pipeline
});
app.Use((context, next) =>
{
    context.Response.WriteAsync("Response from use2 middleware\n");
     return next();  //pass control to the next middleware in the pipeline
});

app.Run();   //terminating middleware that ends the middleware pipeline 
