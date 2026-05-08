using System.Collections.Generic;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Persistance
{
    public interface IWorkPeriodDao
    {
        void StartWorkPeriod(string description,IWorkspace workspace);
        void StopWorkPeriod(string description, IWorkspace workspace);
        IEnumerable<WorkPeriod> GetLastWorkPeriods(int count);
    }
}
