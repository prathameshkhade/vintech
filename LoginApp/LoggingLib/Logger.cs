using Serilog;

namespace LoggingLib
{
    public static class Logger
    {
        private readonly static Serilog.ILogger _logger;

        static Logger()
        {
            _logger = new LoggerConfiguration()
                .WriteTo.File("../../../../Logs/LoginApp-.log", rollingInterval: RollingInterval.Day)
                .WriteTo.Console()
                .CreateLogger();
        }

        public static void LogInfo(string message, params object[] args)
        {
            _logger.Information(message + " at {Timestamp}", args.Concat(new object[] { DateTime.Now }).ToArray());
        }

        public static void LogLoginSuccess(string username)
        {
            LogInfo("LOGIN SUCCESS: {Username}", username);
        }

        public static void LogWarning(string message, params object[] args)
        {
            _logger.Warning(message, " at {Timestamp}", args.Concat(new object[] { DateTime.Now }).ToArray());
        }

        public static void LogLoginFailed(string username, string reason)
        {
            LogWarning("LOGIN FAILED: {Username}, Reason: {Reason}", username, reason);
        }

        public static void LogDebug(string message, params object[] args)
        {
            _logger.Debug(message, " at {Timestamp} ", args.Concat(new object[] { DateTime.Now }).ToArray());
        }

        public static void LogError(string message, params object[] args)
        {
            _logger.Error(message, " at {Timestamp} ", args.Concat(new object[] { DateTime.Now }).ToArray());
        }

        public static void LogFatal(string message, params object[] args)
        {
            _logger.Fatal(message, " at {Timestamp} ", args.Concat(new object[] { DateTime.Now }).ToArray());
        }

        public static void LogVerbose(string message, params object[] args)
        {
            _logger.Verbose(message, " at {Timestamp} ", args.Concat(new object[] { DateTime.Now }).ToArray());
        }
    }
}
