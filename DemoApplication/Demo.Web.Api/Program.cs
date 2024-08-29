using Demo.Application;
using Demo.Infrastructure.Sql;
using Demo.Web.Api.BackgroundTask;
using Demo.Web.Api.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(o =>
{
    //o.UseInMemoryDatabase("Employee");
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IApplicationDBContext, ApplicationDBContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRateLimiter(o =>
{
    o.AddFixedWindowLimiter(policyName: "fixed", options =>
    {
        options.Window = TimeSpan.FromSeconds(12);
        options.PermitLimit = 4;
        options.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
        options.QueueLimit = 2;
    });
});

builder.Services.Configure<HostOptions>(o =>
{ 
    o.ServicesStartConcurrently = true;
    o.ServicesStopConcurrently = true;
});

builder.Services.AddHostedService<PeriodicBackgroundTask>();

builder.Services.AddHealthChecks().AddCheck<CustomHealthCheck>("custom_health_check");


var app = builder.Build();

if (app.Environment.IsDevelopment())
{ 
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRateLimiter();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health");
});

app.Run();
