using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using OpenDesk.Presentation.Common.Commands;
using OpenDesk.Presentation.Common.ModelBase;
using OpenDesk.Presentation.Common.Services;

namespace OpenDesk.Modules.ManagementModule
{
    [Export]
    public class ManagementViewModel : ModelListViewModelBase
    {
        public ObservableCollection<DashboardCommandCategory> CategoryView
        {
            get
            {
                var result = new ObservableCollection<DashboardCommandCategory>(
                     PresentationServices.DashboardCommandCategories.OrderBy(x => x.Order));
                return result;
            }
        }

        protected override string GetHeaderInfo()
        {
            return "Dashboard";
        }

        public void Refresh()
        {
            RaisePropertyChanged(() => CategoryView);
        }
    }
}
