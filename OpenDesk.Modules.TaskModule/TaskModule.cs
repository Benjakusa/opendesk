using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using OpenDesk.Domain.Models.Tasks;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common;
using OpenDesk.Presentation.Common.ModelBase;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Modules.TaskModule
{
    [ModuleExport(typeof(TaskModule))]
    public class TaskModule : ModuleBase
    {
        [ImportingConstructor]
        public TaskModule()
        {
            AddDashboardCommand<EntityCollectionViewModelBase<TaskTypeViewModel, TaskType>>(Resources.TaskType.ToPlural(), Resources.Settings, 20);
        }
    }
}
