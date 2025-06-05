using Serilog;

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

            // Configure Serilog for logging
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("../../../../Logs/Auth-.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Application.Run(new Login());
        }
    }
}
