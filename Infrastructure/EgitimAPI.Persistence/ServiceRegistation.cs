using EgitimAPI.Application.Abstractions;
using EgitimAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace EgitimAPI.Persistence;

public static class ServiceRegistation 
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IMemberService,MemberService>();
    }
}