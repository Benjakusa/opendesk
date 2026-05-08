using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.AccountModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class CreateBatchAccountTransactionDocument : ActionType
    {
        private readonly IAccountService _accountService;

        [ImportingConstructor]
        public CreateBatchAccountTransactionDocument(IAccountService accountService)
        {
            _accountService = accountService;
        }

        protected override object GetDefaultData()
        {
            return new { AccountTransactionDocumentName = "" };
        }

        protected override string GetActionName()
        {
            return Resources.BatchCreateDocuments;
        }

        protected override string GetActionKey()
        {
            return ActionNames.CreateBatchAccountTransactionDocument;
        }

        public override void Process(ActionData actionData)
        {
            var documentName = actionData.GetAsString("AccountTransactionDocumentName");
            _accountService.CreateBatchAccountTransactionDocument(documentName);
        }
    }
}
