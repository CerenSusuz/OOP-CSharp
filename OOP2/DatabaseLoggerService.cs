using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Db Logged...");
        }
    }
}
