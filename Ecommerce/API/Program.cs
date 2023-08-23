using DatabaseAccessLayer.BusinessLogic;
using DatabaseAccessLayer.EcommerceDBContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using DatabaseAccessLayer.Models;
using System.Data.Common;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

//Register services
builder.Services.AddScoped<CategoryBusinessLogic>();
builder.Services.AddScoped<ProductBusinessLogic>();
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
app.MapGet("category/", (CategoryBusinessLogic CatBiz) => CatBiz.GetCategories());
app.MapPost("category", (Category category, CategoryBusinessLogic CatBiz) =>
{
    return Results.Ok(CatBiz.AddCategory(category));
});
app.MapGet("category/{id}", (Guid id, CategoryBusinessLogic CatBiz) => CatBiz.GetCategoryById(id));
app.MapGet("product/", (ProductBusinessLogic ProductBiz) => ProductBiz.GetProducts());
app.MapPost("product", (Product products, ProductBusinessLogic ProductBiz) =>
{
    return Results.Ok(ProductBiz.AddProduct(products));
});
//Register swagger API middle wares
app.UseCors("corsapp");
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
