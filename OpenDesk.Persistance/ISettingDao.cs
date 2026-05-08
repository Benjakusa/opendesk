using System.Collections.Generic;
using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Persistance
{
    public interface ISettingDao
    {
        string GetNextString(int numeratorId);
        int GetNextNumber(int numeratorId);
        IEnumerable<Terminal> GetTerminals();
    }
}
