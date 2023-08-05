using Microsoft.Extensions.Configuration;

namespace PostgreSqlWithEntityFrameWork.DataAccess;

public static class ConnectionSetup
{
    public static string GetConnectionString(string serverName)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("C:\\Users\\novru\\source\\repos\\PostgreSqlWithEntityFrameWork\\PostgreSqlWithEntityFrameWork\\appsettings.json")
            .Build();

        var conStr = builder.GetConnectionString(serverName);

        return conStr;
    }
}
