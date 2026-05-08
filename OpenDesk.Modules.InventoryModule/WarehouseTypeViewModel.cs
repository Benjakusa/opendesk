using System;
using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Inventory;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common.ModelBase;

namespace OpenDesk.Modules.InventoryModule
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    class WarehouseTypeViewModel : EntityViewModelBase<WarehouseType>
    {
        public override Type GetViewType()
        {
            return typeof(WarehouseTypeView);
        }

        public override string GetModelTypeString()
        {
            return Resources.WarehouseType;
        }
    }
}
