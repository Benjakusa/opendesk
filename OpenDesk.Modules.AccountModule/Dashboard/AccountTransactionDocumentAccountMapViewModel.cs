using OpenDesk.Domain.Models.Accounts;
using OpenDesk.Localization.Properties;
using OpenDesk.Services;

namespace OpenDesk.Modules.AccountModule.Dashboard
{
    internal class AccountTransactionDocumentAccountMapViewModel
    {
        public AccountTransactionDocumentAccountMapViewModel(IAccountService accountService, AccountTransactionDocumentAccountMap accountTransactionDocumentAccountMap, AccountType masterAccountType, AccountType mappingAccountType)
        {
            Model = accountTransactionDocumentAccountMap;
            AccountSelector = new AccountSelectViewModel(accountService, masterAccountType, Model.AccountName, (x, y) => { Model.AccountId = y; Model.AccountName = x; });
            if (mappingAccountType != null)
            {
                MappedAccountSelector = new AccountSelectViewModel(accountService, mappingAccountType, Model.MappedAccountName, (x, y) => { Model.MappedAccountId = y; Model.MappedAccountName = x; });
            }
        }

        public AccountTransactionDocumentAccountMap Model { get; set; }
        public AccountSelectViewModel AccountSelector { get; set; }
        public AccountSelectViewModel MappedAccountSelector { get; set; }
    }
}