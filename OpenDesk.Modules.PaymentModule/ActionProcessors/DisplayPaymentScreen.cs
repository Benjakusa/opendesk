using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.PaymentModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class DisplayPaymentScreen : ActionType
    {
        private readonly ITicketService _ticketService;

        [ImportingConstructor]
        public DisplayPaymentScreen(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null && ticket != Ticket.Empty && _ticketService.CanSettleTicket(ticket))
            {
                ticket.PublishEvent(EventTopicNames.MakePayment);
            }
        }

        protected override object GetDefaultData()
        {
            return new object();
        }

        protected override string GetActionName()
        {
            return Resources.DisplayPaymentScreen;
        }

        protected override string GetActionKey()
        {
            return ActionNames.DisplayPaymentScreen;
        }
    }
}
