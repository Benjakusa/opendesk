using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.AccountModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class PrintAccountScreen : ActionType
    {
        private readonly IReportServiceClient _reportServiceClient;
        private readonly ICacheService _cacheService;

        [ImportingConstructor]
        public PrintAccountScreen(IReportServiceClient reportServiceClient, ICacheService cacheService)
        {
            _reportServiceClient = reportServiceClient;
            _cacheService = cacheService;
        }

        public override void Process(ActionData actionData)
        {
            var screenName = actionData.GetAsString("AccountScreenName");
            var screen = _cacheService.GetAccountScreens().FirstOrDefault(x => x.Name == screenName);
            if (screen != null)
            {
                _reportServiceClient.PrintAccountScreen(screen);
            }
        }

        protected override object GetDefaultData()
        {
            return new { AccountScreenName = "" };
        }

        protected override string GetActionName()
        {
            return Resources.PrintAccountScreen;
        }

        protected override string GetActionKey()
        {
            return "PrintAccountScreen";
        }
    }
}
