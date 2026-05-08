using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using OpenDesk.Presentation.Common.ModelBase;

namespace OpenDesk.Modules.AutomationModule.WidgetCreators
{

    public class AutomationButtonWidgetSettings
    {
        private NameWithValue _commandNameValue;
        public NameWithValue CommandNameValue
        {
            get { return _commandNameValue ?? (_commandNameValue = new NameWithValue()); }
        }

        [Browsable(false)]
        public string CommandName { get { return CommandNameValue.Text; } set { CommandNameValue.Text = value; } }

        public string Value { get; set; }
        public string Caption { get; set; }
        public string ButtonColor { get; set; }
    }
}
