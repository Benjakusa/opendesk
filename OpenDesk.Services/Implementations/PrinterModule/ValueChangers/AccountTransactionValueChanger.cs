using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Accounts;

namespace OpenDesk.Services.Implementations.PrinterModule.ValueChangers
{
    [Export]
    public class AccountTransactionValueChanger : AbstractValueChanger<AccountTransaction>
    {
        public override string GetTargetTag()
        {
            return "TRANSACTIONS";
        }

        protected override string GetModelName(AccountTransaction model)
        {
            return model.Name;
        }
    }
}