using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace PucksAndProgramming.Common.Utilities
{
    public static class LogManager
    {
        public static ILoggerFactory LoggerFactory { get; } = new LoggerFactory();

        public static ILogger CreateLogger<T>()
        {
            return LoggerFactory.CreateLogger<T>();
        }
    }
}
