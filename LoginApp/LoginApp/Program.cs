using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace LoginApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Configure the logging service
            services.AddLogging(builder => {
                builder.AddConsole();
                builder.AddFile("../../../../logs/Login-{Date}.log", LogLevel.Information);
            });

            // Service Provider
            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<ILogger<Login>>();

            Application.Run(new Login(logger));
        }
    }
}