// See https://aka.ms/new-console-template for more information
using Foo;
using Microsoft.Extensions.Logging;

Console.WriteLine("Hello, World!");

Log.ThisHappened(new Logger());

namespace Foo
{
    static partial class Log
    {
        [LoggerMessage2(Level = LogLevel.Information)]
        public static partial void ThisHappened(ILogger logger);
    }

    class Logger : ILogger, IDisposable
    {
        public void Dispose() { }

        public IDisposable BeginScope<TState>(TState state)
        {
            return this;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
        }
    }
}
