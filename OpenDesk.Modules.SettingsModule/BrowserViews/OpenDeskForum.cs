using System;
using System.Linq;
using OpenDesk.Localization.Properties;

namespace OpenDesk.Modules.SettingsModule.BrowserViews
{
    class OpenDeskForum : BrowserViewModel
    {
        public OpenDeskForum()
        {
            Header = string.Format("OpenDesk {0}", Resources.Forum);
            Url = "https://github.com/benjakusa/OpendeskPOS";
        }
    }
}
