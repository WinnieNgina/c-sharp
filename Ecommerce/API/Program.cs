using DatabaseAccessLayer.BusinessLogic;
using DatabaseAccessLayer.EcommerceDBContext;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Register services
builder.Services.AddScoped<CategoryBusinessLogic>();
//Registering DbContext
builder.Services.AddDbContext<EcommerceContext>(options => options.UseSqlServer(builder.Configuration["DbConnection"]));

app.MapGet("/", () => "Hello World!");

app.Run();
