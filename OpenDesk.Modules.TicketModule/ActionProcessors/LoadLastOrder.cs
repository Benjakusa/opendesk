using System.ComponentModel.Composition;
using System.Linq;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.TicketModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class LoadLastOrder : ActionType
    {
        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null && ticket.Orders.Count > 0)
            {
                actionData.DataObject.Order = ticket.Orders.Last();
            }
        }

        protected override object GetDefaultData()
        {
            return new object();
        }

        protected override string GetActionName()
        {
            return Resources.LoadLastOrder;
        }

        protected override string GetActionKey()
        {
            return "LoadLastOrder";
        }
    }
}
