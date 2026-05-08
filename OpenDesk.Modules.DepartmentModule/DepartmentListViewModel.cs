using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Tickets;
using OpenDesk.Presentation.Common.ModelBase;

namespace OpenDesk.Modules.DepartmentModule
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    public class DepartmentListViewModel : EntityCollectionViewModelBase<DepartmentViewModel, Department>
    {

    }
}
