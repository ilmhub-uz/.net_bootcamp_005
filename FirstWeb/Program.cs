using System.Reflection;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Adding Controller
builder.Services.AddControllers();

//Adding Swagger with Docs  https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-7.0
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Sample API",
        Description = "This API is sample for learning purposes.",
        TermsOfService = new Uri("https://ilmhub.uz/"),
        Contact = new OpenApiContact
        {
            Name = "Our Contacts",
            Url = new Uri("https://ilmhub.uz/")
        },
        
        License = new OpenApiLicense
        {
            Name = "Open Source License",
            Url = new Uri("https://ilmhub.uz/")
        }
    });
    
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    
});

// Need to display documents on Swagger
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Will run swagger if it is on development mode.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
// Controllers routing
app.MapControllers();

app.Run();
