using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using OpenDesk.Presentation.Common;


namespace OpenDesk.Modules.ManagementModule
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    /// 

    [Export]
    public partial class ManagementView : UserControl
    {
        [ImportingConstructor]
        public ManagementView(ManagementViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            Splitter.Height = new GridLength(0);
            KeyboardPanel.Height = new GridLength(0);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            CommonEventPublisher.PublishDashboardUnloadedEvent(this);
        }
    }
}
