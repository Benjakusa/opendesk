using System.Windows.Input;

namespace OpenDesk.Presentation.Common
{
    public interface ICaptionCommand : ICommand
    {
        string Caption { get; set; }
    }
}
