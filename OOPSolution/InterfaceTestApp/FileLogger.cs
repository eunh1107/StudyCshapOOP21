using System.Diagnostics;
using System.Net.Http;

namespace InterfaceTestApp
{
    class FileLogger : ILogger //ver.12에서 업데이트
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"File error : {error}");
        }

        public void WriteLog(string message)
        {
            Debug.WriteLine($"파일 txt.log에 저장 : {message}");
        }
    }
}
