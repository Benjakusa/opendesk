using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Services;

namespace OpenDesk.Modules.PaymentModule
{
    [Export]
    public class PaymentButtonsViewModel : ObservableObject
    {
        private readonly IApplicationState _applicationState;

        [ImportingConstructor]
        public PaymentButtonsViewModel(IApplicationState applicationState)
        {
            _applicationState = applicationState;
            PaymentButtonGroup = new PaymentButtonGroupViewModel();
        }

        public PaymentButtonGroupViewModel PaymentButtonGroup { get; set; }

        public void Update(ForeignCurrency foreignCurrency)
        {
            PaymentButtonGroup.Update(_applicationState.GetPaymentScreenPaymentTypes(), foreignCurrency);
            RaisePropertyChanged(() => PaymentButtonGroup);
        }

        public void SetButtonCommands(ICaptionCommand makePaymentCommand, ICaptionCommand settleCommand, ICaptionCommand closeCommand)
        {
            PaymentButtonGroup.SetButtonCommands(makePaymentCommand, settleCommand, closeCommand);
        }
    }
}
