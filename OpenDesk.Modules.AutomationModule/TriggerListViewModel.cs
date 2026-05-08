using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Presentation.Common.ModelBase;
using OpenDesk.Presentation.Services;

namespace OpenDesk.Modules.AutomationModule
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    class TriggerListViewModel : EntityCollectionViewModelBase<TriggerViewModel, Trigger>
    {
        private readonly ITriggerService _triggerService;
        private readonly IMethodQueue _methodQueue;

        [ImportingConstructor]
        public TriggerListViewModel(ITriggerService triggerService, IMethodQueue methodQueue)
        {
            _triggerService = triggerService;
            _methodQueue = methodQueue;
        }

        protected override void OnDeleteItem(object obj)
        {
            base.OnDeleteItem(obj);
            _methodQueue.Queue("UpdateCronObjects", _triggerService.UpdateCronObjects);
        }
    }
}
