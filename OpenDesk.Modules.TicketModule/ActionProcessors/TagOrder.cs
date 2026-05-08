using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Services;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services;
using OpenDesk.Services.Common;

namespace OpenDesk.Modules.TicketModule.ActionProcessors
{
    [Export(typeof(IActionType))]
    class TagOrder : OrderTagOperation
    {
        [ImportingConstructor]
        public TagOrder(ICacheService cacheService, ITicketService ticketService)
            : base(cacheService, ticketService)
        {
        }

        protected override string GetActionName()
        {
            return Resources.TagOrder;
        }

        protected override string GetActionKey()
        {
            return ActionNames.TagOrder;
        }
    }
}
