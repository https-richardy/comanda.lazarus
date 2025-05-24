namespace Comanda.Establishment.WebApi;

internal static class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.LoadEnvironment();
        builder.Services.AddServices(builder.Configuration);

        var application = builder.Build();

        application.SetupPipeline(application.Environment);
        application.Run();
    }
}
