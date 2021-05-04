using System;

namespace UsinginterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        
        public DateTime currentDate { get; set; }

        public ConsoleLogger()
        {
        }

        public ConsoleLogger(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"콘솔로그 : {this.currentDate} -> {message}");
        }
    }
}
