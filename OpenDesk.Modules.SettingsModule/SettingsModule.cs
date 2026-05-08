using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Localization.Properties;
using OpenDesk.Modules.SettingsModule.BrowserViews;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.ModelBase;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Modules.SettingsModule
{
    [ModuleExport(typeof(SettingsModule))]
    public class SettingsModule : ModuleBase
    {
        [ImportingConstructor]
        public SettingsModule()
        {
            AddDashboardCommand<SettingsViewModel>(Resources.LocalSettings, Resources.Settings, 20);
            AddDashboardCommand<TerminalListViewModel>(Resources.Terminals, Resources.Settings, 21);
            AddDashboardCommand<EntityCollectionViewModelBase<NumeratorViewModel, Numerator>>(Resources.Numerators, Resources.Settings, 21);
            AddDashboardCommand<EntityCollectionViewModelBase<ForeignCurrencyViewModel, ForeignCurrency>>(string.Format(Resources.List_f, Resources.Currency), Resources.Settings, 21);
            AddDashboardCommand<EntityCollectionViewModelBase<StateViewModel, State>>(Resources.State.ToPlural(), Resources.Settings, 21);
            AddDashboardCommand<ProgramSettingsViewModel>(Resources.ProgramSettings, Resources.Settings, 22);
            AddDashboardCommand<OpenDeskWebsite>(Resources.OpenDeskWebsite, Resources.SambaNetwork, 90);
            AddDashboardCommand<OpenDeskDocumentation>(string.Format("OpenDesk {0}", Resources.Documentation), Resources.SambaNetwork, 91);
            AddDashboardCommand<OpenDeskForum>(string.Format("OpenDesk {0}", Resources.Forum), Resources.SambaNetwork, 92);
            AddDashboardCommand<OpenDeskDevelopment>(string.Format("OpenDesk {0}", Resources.Development), Resources.SambaNetwork, 93);
            AddDashboardCommand<OpenDeskWiki>(string.Format("OpenDesk {0}", Resources.Wiki), Resources.SambaNetwork, 94);
        }
    }
}
