using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Common.Services;

namespace OpenDesk.Modules.NavigationModule
{
    [Export]
    public class NavigationViewModel : ObservableObject
    {
        public ObservableCollection<ICategoryCommand> CategoryView
        {
            get
            {
                return new ObservableCollection<ICategoryCommand>(
                    PresentationServices.NavigationCommandCategories.OrderBy(x => x.Order));
            }
        }

        public void Refresh()
        {
            RaisePropertyChanged(() => CategoryView);
        }
    }
}
