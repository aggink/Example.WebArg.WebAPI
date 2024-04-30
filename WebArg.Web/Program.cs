using Microsoft.EntityFrameworkCore;
using Serilog;
using WebArg.Storage.Database;
using WebArg.Web.Extensions;
using WebArg.Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), o =>
    {

        o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
    }));

builder.Host.UseSerilog((context, Configuration) =>
   Configuration.ReadFrom.Configuration(context.Configuration));

builder.Services
    .AddControllers()
    .AddNewtonsoftJson();

builder.Services.AddSwaggerSetup();
builder.Services.AddFeaturesServices(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseSerilogRequestLogging();

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