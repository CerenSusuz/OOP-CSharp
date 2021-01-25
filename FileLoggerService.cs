using System;

namespace OOP2
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File Logged...");
        }
    }
}
