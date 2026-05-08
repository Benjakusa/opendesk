using System.Collections.Generic;
using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Modules.ModifierModule
{
    [Export]
    public class TicketLogViewerViewModel : ObservableObject
    {

        public ICaptionCommand CloseCommand { get; set; }

        public TicketLogViewerViewModel()
        {
            CloseCommand = new CaptionCommand<string>(Resources.Close, OnClose);
        }

        private Ticket _selectedTicket;
        public Ticket SelectedTicket
        {
            get { return _selectedTicket; }
            set
            {
                _selectedTicket = value;
                RaisePropertyChanged(() => SelectedTicket);
                if (SelectedTicket != null)
                {
                    _logs = null;
                    RaisePropertyChanged(() => Logs);
                }
            }
        }

        private IEnumerable<TicketLogValue> _logs;
        public IEnumerable<TicketLogValue> Logs
        {
            get { return _logs ?? (_logs = SelectedTicket != null ? SelectedTicket.GetTicketLogValues() : null); }
            set { _logs = value; RaisePropertyChanged(() => Logs); }
        }

        private void OnClose(string obj)
        {
            SelectedTicket = null;
            EventServiceFactory.EventService.PublishEvent(EventTopicNames.ActivatePosView);
        }
    }
}
