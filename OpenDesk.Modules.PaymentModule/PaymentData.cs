using OpenDesk.Domain.Models.Tickets;

namespace OpenDesk.Modules.PaymentModule
{
    public class PaymentData
    {
        public PaymentType PaymentType { get; set; }
        public ChangePaymentType ChangePaymentType { get; set; }
        public decimal PaymentDueAmount { get; set; }
        public decimal TenderedAmount { get; set; }
    }
}