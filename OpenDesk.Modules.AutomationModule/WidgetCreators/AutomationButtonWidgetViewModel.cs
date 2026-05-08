using System.ComponentModel;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Infrastructure.Helpers;
using OpenDesk.Persistance;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Common.Widgets;
using OpenDesk.Presentation.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.AutomationModule.WidgetCreators
{
    class AutomationButtonWidgetViewModel : WidgetViewModel
    {
        private readonly IApplicationState _applicationState;
        private readonly IAutomationDao _automationDao;

        [Browsable(false)]
        public CaptionCommand<AutomationButtonWidgetViewModel> ItemClickedCommand { get; set; }

        public AutomationButtonWidgetViewModel(Widget widget, IApplicationState applicationState, IAutomationDao automationDao)
            : base(widget, applicationState)
        {
            _applicationState = applicationState;
            _automationDao = automationDao;
            ItemClickedCommand = new CaptionCommand<AutomationButtonWidgetViewModel>("", OnItemClicked);
        }

        private void OnItemClicked(AutomationButtonWidgetViewModel obj)
        {
            _applicationState.NotifyEvent(RuleEventNames.AutomationCommandExecuted,
                new
                    {
                        Ticket = Ticket.Empty,
                        AutomationCommandName = obj.Settings.CommandName,
                        CommandValue = obj.Settings.Value
                    });
        }

        protected override object CreateSettingsObject()
        {
            return JsonHelper.Deserialize<AutomationButtonWidgetSettings>(_model.Properties);
        }

        public override void Refresh()
        {
            //
        }

        [Browsable(false)]
        public AutomationButtonWidgetSettings Settings { get { return SettingsObject as AutomationButtonWidgetSettings; } }


        protected override void BeforeEditSettings()
        {
            Settings.CommandNameValue.UpdateValues(_automationDao.GetAutomationCommandNames());
        }
    }
}
