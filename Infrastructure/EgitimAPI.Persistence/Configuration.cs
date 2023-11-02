using Microsoft.Extensions.Configuration;

namespace EgitimAPI.Persistence;

static class Configuration
{
    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EgitimAPI.Api"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("MySQLConnectionString");
        }
    }
}