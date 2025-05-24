namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class HttpPipelineBuilderExtension
{
    public static void SetupPipeline(this IApplicationBuilder app, IWebHostEnvironment hostingEnvironment)
    {
        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseCors();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseStaticFiles();
    }
}