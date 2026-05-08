using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Modules.ModifierModule
{
    [Export]
    public class TicketNoteEditorViewModel : ObservableObject
    {
        private Ticket _selectedTicket;
        public Ticket SelectedTicket
        {
            get { return _selectedTicket; }
            set
            {
                _selectedTicket = value;
                RaisePropertyChanged(() => SelectedTicket);
            }
        }

        public ICaptionCommand CloseCommand { get; set; }

        public TicketNoteEditorViewModel()
        {
            CloseCommand = new CaptionCommand<string>(Resources.Close, OnClose);
        }

        private void OnClose(string obj)
        {
            SelectedTicket = null;
            EventServiceFactory.EventService.PublishEvent(EventTopicNames.ActivatePosView);
        }
    }
}
