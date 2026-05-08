using System;
using System.Linq;
using OpenDesk.Localization.Properties;

namespace OpenDesk.Modules.SettingsModule.BrowserViews
{
    class OpenDeskDevelopment : BrowserViewModel
    {
        public OpenDeskDevelopment()
        {
            Header = string.Format("OpenDesk {0}", Resources.Development);
            Url = "https://github.com/benjakusa/OpendeskPOS";
        }
    }
}
