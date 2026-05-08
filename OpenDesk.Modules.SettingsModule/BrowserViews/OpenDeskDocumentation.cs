using System;
using System.Linq;
using OpenDesk.Localization.Properties;

namespace OpenDesk.Modules.SettingsModule.BrowserViews
{
    class OpenDeskDocumentation : BrowserViewModel
    {
        public OpenDeskDocumentation()
        {
            Header = string.Format("OpenDesk {0}", Resources.Documentation);
            Url = "https://github.com/benjakusa/OpendeskPOS";
        }
    }
}
