using System;
using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.TicketModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class UpdateTicketCalculation : ActionType
    {
        private readonly ICacheService _cacheService;
        private readonly ITicketService _ticketService;

        [ImportingConstructor]
        public UpdateTicketCalculation(ICacheService cacheService, ITicketService ticketService)
        {
            _cacheService = cacheService;
            _ticketService = ticketService;
        }

        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null)
            {
                var calculationTypeName = actionData.GetAsString("CalculationType");
                var calculationType = _cacheService.GetCalculationTypeByName(calculationTypeName);
                if (calculationType != null)
                {
                    var amount = actionData.GetAsDecimal("Amount");
                    ticket.AddCalculation(calculationType, amount);
                    _ticketService.RecalculateTicket(ticket);
                    EventServiceFactory.EventService.PublishEvent(EventTopicNames.RegenerateSelectedTicket);
                }
            }
        }

        protected override object GetDefaultData()
        {
            return new { CalculationType = "", Amount = 0m };
        }

        protected override string GetActionName()
        {
            return Resources.UpdateTicketCalculation;
        }

        protected override string GetActionKey()
        {
            return ActionNames.UpdateTicketCalculation;
        }
    }
}
