using System.ComponentModel;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.Widgets;
using OpenDesk.Presentation.Services;
using OpenDesk.Services;

namespace OpenDesk.Modules.TicketModule.Widgets.TicketExplorer
{
    class TicketExplorerWidgetViewModel : WidgetViewModel
    {
        public TicketExplorerWidgetViewModel(Widget model, IApplicationState applicationState,
             ITicketServiceBase ticketServiceBase, IUserService userService, ICacheService cacheService)
            : base(model, applicationState)
        {
            TicketExplorerViewModel = new TicketExplorerViewModel(ticketServiceBase, userService, cacheService, applicationState);
        }

        [Browsable(false)]
        public TicketExplorerViewModel TicketExplorerViewModel { get; private set; }

        protected override object CreateSettingsObject()
        {
            return null;
        }

        public override void Refresh()
        {
            TicketExplorerViewModel.Refresh();
        }
    }
}
