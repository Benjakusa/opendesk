using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenDesk.Services
{
    public interface ILogService
    {
        void LogError(Exception e);
        void LogError(Exception e, string userMessage);
        void Log(string message);
    }
}
