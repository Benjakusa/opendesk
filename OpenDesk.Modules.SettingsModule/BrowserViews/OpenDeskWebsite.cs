using System;
using System.Linq;
using OpenDesk.Localization.Properties;

namespace OpenDesk.Modules.SettingsModule.BrowserViews
{
    class OpenDeskWebsite : BrowserViewModel
    {
        public OpenDeskWebsite()
        {
            Header = string.Format("OpenDesk {0}", Resources.Website);
            Url = "https://github.com/benjakusa/OpendeskPOS";
        }
    }
}
