using Microsoft.EntityFrameworkCore;
using WebArg.Logic.Extensions;
using WebArg.Storage.Database;
using WebArg.Web.Extensions;
using WebArg.Web.Middlewares;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), o =>
    {

        o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
    }));

builder.Services
    .AddControllersWithViews()
    .AddDataAnnotationsLocalization()
    .AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMappers();
builder.Services.AddLogicServices();
builder.Services.AddFeaturesServices();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseHsts();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();