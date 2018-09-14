﻿

using System;

namespace Hyper.Domain.Models
{
    public class Log
    {
        public Guid Id { get; private set; }
        public LogLevel LogLevel { get; private set; }
        public string Message { get; private set; }
        public DateTime CreationTime { get; private set; }

        public string LogLevelString
        {
            get => LogLevel.ToString();
            set => LogLevel = (LogLevel)Enum.Parse(typeof(LogLevel), value);
        }

        public Log() { }
        public Log(LogLevel logLevel, string message)
        {
            Id = Guid.NewGuid();
            LogLevel = logLevel;
            Message = message;
            CreationTime = DateTime.Now;
        }
    }
}
