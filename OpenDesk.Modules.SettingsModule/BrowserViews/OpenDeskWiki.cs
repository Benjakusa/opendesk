using System;
using System.Linq;
using OpenDesk.Localization.Properties;

namespace OpenDesk.Modules.SettingsModule.BrowserViews
{
    class OpenDeskWiki : BrowserViewModel
    {
        public OpenDeskWiki()
        {
            Header = string.Format("OpenDesk {0}", Resources.Wiki);
            Url = "https://github.com/benjakusa/OpendeskPOS";
        }
    }
}
