using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.TicketModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class UpdateTicketTag : ActionType
    {
        private readonly ITicketService _ticketService;

        [ImportingConstructor]
        public UpdateTicketTag(ITicketService ticketService, ICacheService cacheService)
        {
            _ticketService = ticketService;
        }

        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null)
            {
                var tagName = actionData.GetAsString("TagName");
                var tagValue = actionData.GetAsString("TagValue");
                _ticketService.UpdateTag(ticket, tagName, tagValue);
            }
        }

        protected override object GetDefaultData()
        {
            return new { TagName = "", TagValue = "" };
        }

        protected override string GetActionName()
        {
            return Resources.UpdateTicketTag;
        }

        protected override string GetActionKey()
        {
            return ActionNames.UpdateTicketTag;
        }
    }
}
