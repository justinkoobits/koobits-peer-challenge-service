
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Koobits.PeerChallenge.Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebApiFilters(this IServiceCollection services)
        {
            // services.AddScoped<TimeValidationAttribute>();

            // services.AddScoped<DayRestrictionAttribute>();

            return services;
        }
    }
}

