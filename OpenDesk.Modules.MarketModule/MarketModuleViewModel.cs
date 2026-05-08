using System.Collections.Generic;
using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Menus;
using OpenDesk.Presentation.Common;
using OpenDesk.Services;

namespace OpenDesk.Modules.MarketModule
{
    [Export]
    public class MarketModuleViewModel : ObservableObject
    {
        private string _activeUrl;
        public string ActiveUrl
        {
            get { return _activeUrl; }
            set { _activeUrl = value; RaisePropertyChanged(() => ActiveUrl); }
        }
    }
}
