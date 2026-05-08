using OpenDesk.Presentation.Common.Commands;

namespace OpenDesk.Presentation.Common.ModelBase
{
    public interface IEditableCollection
    {
        ICaptionCommand AddItemCommand { get; set; }
        ICaptionCommand EditItemCommand { get; set; }
        ICaptionCommand DeleteItemCommand { get; set; }
    }
}
