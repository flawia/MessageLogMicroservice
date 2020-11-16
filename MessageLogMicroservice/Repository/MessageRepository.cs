using MessageLoggerMicroservice.Interfaces;
using MessageLogMicroservice.Models;
using System;
using System.IO;

namespace MessageLoggerMicroservice.Repository
{
    public class MessageRepository : IMessageRepository
    {
        public void WriteToFile(Message message)
        {
            var logFile = Path.Join(Environment.CurrentDirectory, "Log.txt");
            File.AppendAllText(logFile, $"{message.ToString()}{Environment.NewLine}");
        }
    }
}
