using System.ComponentModel.Composition;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.AutomationModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class SendMessage : ActionType
    {
        private readonly IMessagingService _messagingService;

        [ImportingConstructor]
        public SendMessage(IMessagingService messagingService)
        {
            _messagingService = messagingService;
        }

        public override void Process(ActionData actionData)
        {
            _messagingService.SendMessage("ActionMessage", actionData.GetAsString("Command"));
        }

        protected override object GetDefaultData()
        {
            return new { Command = "" };
        }

        protected override string GetActionName()
        {
            return Resources.BroadcastMessage;
        }

        protected override string GetActionKey()
        {
            return ActionNames.SendMessage;
        }
    }
}
