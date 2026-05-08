using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common.ModelBase;

namespace OpenDesk.Modules.SettingsModule
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    public class TerminalListViewModel : EntityCollectionViewModelBase<TerminalViewModel, Terminal>
    {
        protected override string CanDeleteItem(Terminal model)
        {
            var count = Workspace.Count<Terminal>();
            if (count == 1) return Resources.DeleteErrorShouldHaveAtLeastOneTerminal;
            return base.CanDeleteItem(model);
        }
    }
}
