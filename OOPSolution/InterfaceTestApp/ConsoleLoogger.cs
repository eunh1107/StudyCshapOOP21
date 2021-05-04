using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLoogger : ILogger //ver.1.0
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러 : {error}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"로그 {DateTime.Now} : {message}");
        }
    }
}
