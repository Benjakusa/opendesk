using System.Collections.Generic;
using OpenDesk.Domain.Models.Automation;

namespace OpenDesk.Persistance
{
    public interface IAutomationDao
    {
        Dictionary<string, string> GetScripts();
        AppAction GetActionById(int appActionId);
        IEnumerable<string> GetAutomationCommandNames();
    }
}
