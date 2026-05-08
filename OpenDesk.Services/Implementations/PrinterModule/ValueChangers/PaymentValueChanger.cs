using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Tickets;

namespace OpenDesk.Services.Implementations.PrinterModule.ValueChangers
{
    [Export]
    public class PaymentValueChanger : AbstractValueChanger<Payment>
    {
        public override string GetTargetTag()
        {
            return "PAYMENTS";
        }

        protected override string GetModelName(Payment model)
        {
            return model.Name;
        }
    }
}
