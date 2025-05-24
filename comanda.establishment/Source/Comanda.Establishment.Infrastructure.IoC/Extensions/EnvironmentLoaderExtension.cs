namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class EnvironmentLoaderExtension
{
    public static void LoadEnvironment(this ConfigurationManager configuration)
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
        var envFilePath = Path.Combine("..", "..", "Environments", $".env.{environment}");

        if (!File.Exists(envFilePath))
            return;

        var lines = File.ReadAllLines(envFilePath);
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
            {
                continue;
            }

            var parts = line.Split('=', 2, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
            {
                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }

        configuration.AddEnvironmentVariables();
    }
}