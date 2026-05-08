using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.Practices.Prism.Commands;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Services.Common;
using OpenDesk.Services;

namespace OpenDesk.Modules.PosModule
{
    [Export]
    public class TicketTypeListViewModel : ObservableObject
    {
        private readonly ICacheService _cacheService;
        public DelegateCommand<TicketType> SelectionCommand { get; set; }
        public CaptionCommand<string> CloseCommand { get; set; }

        [ImportingConstructor]
        public TicketTypeListViewModel(ICacheService cacheService)
        {
            _cacheService = cacheService;
            SelectionCommand = new DelegateCommand<TicketType>(OnSelectTicketType);
            CloseCommand = new CaptionCommand<string>(Resources.Close, OnClose);
            TicketTypeList = new ObservableCollection<TicketType>();
        }

        private void OnClose(string obj)
        {
            CommonEventPublisher.PublishEntityOperation<Entity>(null, EventTopicNames.SelectEntity, EventTopicNames.EntitySelected);
        }

        private void OnSelectTicketType(TicketType obj)
        {
            obj.PublishEvent(EventTopicNames.TicketTypeSelected, true);
        }

        public ObservableCollection<TicketType> TicketTypeList { get; set; }

        public void Update()
        {
            TicketTypeList.Clear();
            TicketTypeList.AddRange(_cacheService.GetTicketTypes());
            RaisePropertyChanged(() => RowCount);
            RaisePropertyChanged(() => ColumnCount);
        }

        public int ColumnCount { get { return TicketTypeList.Count % 7 == 0 ? TicketTypeList.Count / 7 : (TicketTypeList.Count / 7) + 1; } }
        public int RowCount { get { return 7; } }
    }
}
