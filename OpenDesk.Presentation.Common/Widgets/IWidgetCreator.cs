using System.Windows;
using System.Windows.Controls;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Presentation.Services;

namespace OpenDesk.Presentation.Common.Widgets
{
    public interface IWidgetCreator
    {
        string GetCreatorName();
        string GetCreatorDescription();
        FrameworkElement CreateWidgetControl(IDiagram widget, ContextMenu contextMenu);
        Widget CreateNewWidget();
        IDiagram CreateWidgetViewModel(Widget widget, IApplicationState applicationState);
    }
}