using System;
using System.IO;

namespace UsinginterfaceTestApp
{
    class FlieLogger : ILogger 
    {
        private StreamWriter writer;
        public FlieLogger(string path)
        {
            writer = File.CreateText(path); // 파일 만들기
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FileLog{DateTime.Now}／t >>> {message}");
        }
    }
}
