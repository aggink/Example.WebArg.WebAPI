using Serilog;
using WebArg.Web.Extensions;
using WebArg.Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, Configuration) =>
   Configuration.ReadFrom.Configuration(context.Configuration));

builder.Services
    .AddControllers()
    .AddNewtonsoftJson();

builder.Services.AddDatabase(builder.Configuration);

builder.Services.AddAutoMappers();
builder.Services.AddSwaggerSetup();
builder.Services.AddFeaturesServices();
builder.Services.AddFluentValidationSetup(typeof(Program));

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

public partial class Program { }