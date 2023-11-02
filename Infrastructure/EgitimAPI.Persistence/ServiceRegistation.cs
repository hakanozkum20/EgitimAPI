using EgitimAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EgitimAPI.Persistence;

public static class ServiceRegistation 
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<EgitimApiDbContext>(o => o.UseMySql(Configuration.ConnectionString,ServerVersion.AutoDetect(Configuration.ConnectionString)));
        
        // Yarın 8 de.

    }
}