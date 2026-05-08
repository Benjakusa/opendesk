using System;

namespace OpenDesk.Infrastructure
{
    public interface IMessageListener
    {
        string Key { get; }
        void ProcessMessage(string message);
    }
}
