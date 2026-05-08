using System.ComponentModel.Composition;
using System.Linq;
using OpenDesk.Domain.Models.Inventory;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Common.ModelBase;
using OpenDesk.Presentation.Services;

namespace OpenDesk.Modules.InventoryModule
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    class TransactionDocumentListViewModel : EntityCollectionViewModelBase<TransactionDocumentViewModel, InventoryTransactionDocument>
    {
        private readonly IApplicationState _applicationState;

        [ImportingConstructor]
        public TransactionDocumentListViewModel(IApplicationState applicationState)
        {
            _applicationState = applicationState;
        }

        protected override bool CanAddItem(object obj)
        {
            return _applicationState.CurrentWorkPeriod != null;
        }
    }
}
