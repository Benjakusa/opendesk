using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDesk.Infrastructure.Data;

namespace OpenDesk.Presentation.Common.ModelBase
{
    public abstract class EntityViewModelBaseWithMap<TModel, TMapModel, TMapViewModel> : EntityViewModelBase<TModel>
        where TModel : class, IEntityClass
        where TMapModel : class, IAbstractMapModel, new()
        where TMapViewModel : AbstractMapViewModel<TMapModel>, new()
    {
        public MapController<TMapModel, TMapViewModel> MapController { get; set; }

        protected override string GetForeground()
        {
            if (MapController.Maps.Count == 0) return "Gray";
            return base.GetForeground();
        }

        protected override void OnSave(string value)
        {
            base.OnSave(value);
            RaisePropertyChanged(() => Foreground);
        }
    }
}
