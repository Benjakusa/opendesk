using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Services.Common
{
    public interface IWorkPeriodProcessor
    {
        void ProcessWorkPeriodStart(WorkPeriod workPeriod);
        void ProcessWorkPeriodEnd(WorkPeriod workPeriod);
    }
}