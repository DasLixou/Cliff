using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Cliff.Design.Components
{
    public partial class TrackController : UserControl
    {
        public TrackController()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
