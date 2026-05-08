using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common.Widgets;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services.Common;

namespace OpenDesk.Presentation.Common.ActionProcessors
{
    [Export(typeof(IActionType))]
    class SetWidgetValue : ActionType
    {
        public override void Process(ActionData actionData)
        {
            var widgetName = actionData.GetAsString("WidgetName");
            var value = actionData.GetAsString("Value") ?? "";
            if (!string.IsNullOrEmpty(widgetName))
            {
                var data = new WidgetEventData { WidgetName = widgetName, Value = value };
                data.PublishEvent(EventTopicNames.SetWidgetValue);
            }
        }

        protected override object GetDefaultData()
        {
            return new { WidgetName = "", Value = "" };
        }

        protected override string GetActionName()
        {
            return Resources.SetWidgetValue;
        }

        protected override string GetActionKey()
        {
            return ActionNames.SetWidgetValue;
        }
    }
}
