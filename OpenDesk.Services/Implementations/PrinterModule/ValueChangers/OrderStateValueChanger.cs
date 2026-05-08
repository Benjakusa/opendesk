using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Tickets;

namespace OpenDesk.Services.Implementations.PrinterModule.ValueChangers
{
    [Export]
    public class OrderStateValueChanger : AbstractValueChanger<OrderStateValue>
    {
        public override string GetTargetTag()
        {
            return "ORDER STATES";
        }

        protected override string GetModelName(OrderStateValue model)
        {
            return model.StateValue;
        }
    }
}
