using System;
using System.Collections.Generic;
using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Presentation.Services
{
    public interface IWorkPeriodService 
    {
        bool StartWorkPeriod(string description);
        bool StopWorkPeriod(string description);
        IEnumerable<WorkPeriod> GetLastWorkPeriods(int count);
        DateTime GetWorkPeriodStartDate();
    }
}
