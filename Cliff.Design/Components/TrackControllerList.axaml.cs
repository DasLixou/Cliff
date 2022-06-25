using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Cliff.Design.ViewModels;

namespace Cliff.Design.Components
{
    public partial class TrackControllerList : UserControl
    {
        public TrackControllerList()
        {
            InitializeComponent();
            DataContext = new TrackControllerListViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
