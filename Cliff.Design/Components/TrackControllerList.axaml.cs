using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Cliff.Design.Components
{
    public partial class TrackControllerList : UserControl
    {
        public TrackControllerList()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
