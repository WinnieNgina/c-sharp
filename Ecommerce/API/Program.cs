using DatabaseAccessLayer.BusinessLogic;
using DatabaseAccessLayer.EcommerceDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

//Register services
builder.Services.AddScoped<CategoryBusinessLogic>();
//Allows swagger to explore API end points that arein our projects
builder.Services.AddEndpointsApiExplorer();
//Register swagger documentation
builder.Services.AddSwaggerGen();
//Registering DbContext
builder.Services.AddDbContext<EcommerceContext>(options => options.UseSqlServer(builder.Configuration["DbConnection"]));
var app = builder.Build();
#region Run all Pending Migrations
using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<EcommerceContext>();
    var pendingMigrations = ctx.Database.GetPendingMigrations();
    var migrator = ctx.GetInfrastructure().GetService<IMigrator>();
    foreach (var migration in pendingMigrations)
    {
        migrator?.Migrate(migration);
    }
}
#endregion
app.MapGet("/", () => "Hello World!");
//Register swagger API middle wares
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
