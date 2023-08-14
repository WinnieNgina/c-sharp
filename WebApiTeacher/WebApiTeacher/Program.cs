using WebApiTeacher;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//Register services - scope,eg add dbcontext
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<TeachersDBContext>(options => options.UseSqlServer(builder.Configuration["DbConnetion"]));
builder.Services.AddSwaggerGen();
var app = builder.Build();
//Register middlewares - e.g swagger/API's
app.MapPost("mwalimu", (Teacher mwalimu, TeachersDBContext db) =>
{
    db.Add(mwalimu);
    db.SaveChanges();
    return mwalimu;
});
//teacher is the path in this case
app.MapGet("teacher", (TeachersDBContext db) =>
{
    return db.Mwalimu.ToList();
});
app.MapPut("mwalimu/{id}", (int id, Teacher teacher, TeachersDBContext db) =>
{
    Teacher mwalimu = db.Mwalimu.Find(id);
    if (mwalimu == null)
        return Results.NotFound();
    mwalimu.Name = teacher.Name;
    db.SaveChanges();
    return Results.Ok(mwalimu);
});
app.MapDelete("mwalimu/{id}", (int id, TeachersDBContext db) =>
{
    Teacher mwalimu = db.Mwalimu.Find(id);
    if (mwalimu == null)
        return Results.NotFound();
    db.Mwalimu.Remove(mwalimu);
    db.SaveChanges();
    return Results.Ok();
});
//Example of a custom middleware
app.Use(async (context, next) =>
{
    //You can intercept request here before calling any Api
    Console.WriteLine("This is printed before calling any API");
    await next.Invoke();
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
