using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApiTest;

var builder = WebApplication.CreateBuilder(args);
//Dependency injection. Injecting swaggerbuckle and specifying their life time
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<SchoolDBContext>(options => options.UseSqlServer(builder.Configuration["DbConnection"]));
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
app.MapPost("student", (Student student, SchoolDBContext db )=>
{
    db.Add(student);
    db.SaveChanges();
    return student;
}   );
app.MapGet("student", (SchoolDBContext db) =>
{
    return db.Students.ToList();
});
app.MapGet("student/{id}", (int id, SchoolDBContext db) =>
{
    return db.Students.FirstOrDefault(s => s.Id == id);
});
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("corsapp");
app.Run();
