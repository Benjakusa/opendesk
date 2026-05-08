using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Accounts;
using OpenDesk.Domain.Models.Settings;

namespace OpenDesk.Services.Implementations.PrinterModule.ValueChangers
{
    [Export]
    public class AccountTransactionDocumentValueChanger : AbstractValueChanger<AccountTransactionDocument>
    {
        private readonly AccountTransactionValueChanger _accountTransactionValueChanger;

        [ImportingConstructor]
        public AccountTransactionDocumentValueChanger(AccountTransactionValueChanger accountTransactionValueChanger)
        {
            _accountTransactionValueChanger = accountTransactionValueChanger;
        }

        public override string GetTargetTag()
        {
            return "LAYOUT";
        }

        protected override string ReplaceTemplateValues(string templatePart, AccountTransactionDocument model, PrinterTemplate template)
        {
            var result = _accountTransactionValueChanger.Replace(template, templatePart, model.AccountTransactions);
            return result;
        }
    }
}