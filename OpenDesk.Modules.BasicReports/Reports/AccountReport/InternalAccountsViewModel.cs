using System.Windows.Documents;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Services;

namespace OpenDesk.Modules.BasicReports.Reports.AccountReport
{
    class InternalAccountsViewModel : AccountReportViewModelBase
    {
        public InternalAccountsViewModel(IUserService userService, IApplicationState applicationState, ILogService logService, ISettingService settingService)
            : base(userService, applicationState, logService, settingService)
        {
        }

        protected override FlowDocument GetReport()
        {
            return CreateReport(Resources.InternalAccounts, null, true);
        }

        protected override string GetHeader()
        {
            return Resources.InternalAccounts;
        }
    }
}
