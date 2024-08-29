using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Demo.Web.Api.Middlewares
{
    public class CustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context
            , CancellationToken cancellationToken = default)
        {
            return Task.FromResult(true ? HealthCheckResult.Healthy("Perfect") : HealthCheckResult.Unhealthy("Not Perfect"));
        }
    }
}
