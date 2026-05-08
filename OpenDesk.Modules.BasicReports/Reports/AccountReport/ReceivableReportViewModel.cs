using System.Windows.Documents;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Services;

namespace OpenDesk.Modules.BasicReports.Reports.AccountReport
{
    public class ReceivableReportViewModel : AccountReportViewModelBase
    {
        public ReceivableReportViewModel(IUserService userService, IApplicationState applicationState, ILogService logService, ISettingService settingService)
            : base(userService, applicationState, logService, settingService)
        {
        }

        protected override FlowDocument GetReport()
        {
            return CreateReport(Resources.AccountsReceivable, true, false);
        }

        protected override string GetHeader()
        {
            return Resources.AccountsReceivable;
        }
    }
}
