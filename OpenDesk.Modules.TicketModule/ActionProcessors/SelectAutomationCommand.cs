using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.TicketModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class SelectAutomationCommand : ActionType
    {
        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null)
            {
                CommonEventPublisher.EnqueueTicketEvent(EventTopicNames.SelectAutomationCommand);
            }
        }

        protected override object GetDefaultData()
        {
            return new object();
        }

        protected override string GetActionName()
        {
            return Resources.SelectAutomationCommand;
        }

        protected override string GetActionKey()
        {
            return "SelectAutomationCommand";
        }
    }
}
