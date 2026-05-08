using System;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Localization;
using OpenDesk.Localization.Properties;
using OpenDesk.Presentation.Common.ModelBase;

namespace OpenDesk.Modules.SettingsModule
{
    public class NumeratorViewModel : EntityViewModelBase<Numerator>
    {
        [LocalizedDisplayName("Name")]
        public string NumeratorName
        {
            get { return Model.Name; }
            set { Model.Name = value; }
        }

        [LocalizedDisplayName("NumberFormat")]
        public string NumberFormat
        {
            get { return Model.NumberFormat; }
            set { Model.NumberFormat = value; }
        }

        public override Type GetViewType()
        {
            return typeof(GenericEntityView);
        }

        public override string GetModelTypeString()
        {
            return Resources.Numerator;
        }
    }
}
