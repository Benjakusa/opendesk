using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.PosModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class DisplayTicketLog : ActionType
    {
        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null)
            {
                ticket.PublishEvent(EventTopicNames.DisplayTicketLog);
            }
        }

        protected override object GetDefaultData()
        {
            return null;
        }

        protected override string GetActionName()
        {
            return Resources.DisplayTicketLog;
        }

        protected override string GetActionKey()
        {
            return "DisplayTicketLog";
        }
    }
}
