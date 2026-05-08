using System.Windows.Input;

namespace OpenDesk.Presentation.Common.Commands
{
    public interface ICaptionCommand : ICommand
    {
        string Caption { get; set; }
    }
}
