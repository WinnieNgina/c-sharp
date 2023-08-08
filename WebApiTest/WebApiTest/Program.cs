using Microsoft.OpenApi.Models;
using WebApiTest;

var builder = WebApplication.CreateBuilder(args);
//Dependency injection. Injecting swaggerbuckle and specifying their life time
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Winnie API",
        Description = "My first API",
        TermsOfService = new Uri("https://winnie.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Contact Winnie",
            Url = new Uri("https://winnie.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Winnie License",
            Url = new Uri("https://winnie.com/license")
        }
    });
});
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

app.MapGet("/user/details", () =>  new Student {Age = 40, Name = "Winnie"}).WithTags("Winnie");
app.MapGet("/user/{Age}", (int Age) => new Student { Age = Age, Name = "Winnie" }).WithTags("Winnie");
app.MapPost("user/path", (Student Ven) => Ven).WithTags("Winnie");
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("corsapp");
app.Run();
