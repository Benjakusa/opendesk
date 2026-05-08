using OpenDesk.Domain.Models.Tasks;
using OpenDesk.Presentation.Common;

namespace OpenDesk.Modules.TaskModule.Widgets.TaskEditor
{
    public class TaskCustomFieldEditorModel : ObservableObject
    {
        private string _value;

        public TaskCustomFieldEditorModel(TaskCustomField taskCustomField)
        {
            Model = taskCustomField;
        }

        protected TaskCustomField Model { get; set; }
        public string Name { get { return Model.Name; } }
        public string Value
        {
            get { return _value; }
            set { _value = value; RaisePropertyChanged(() => Value); }
        }
    }
}