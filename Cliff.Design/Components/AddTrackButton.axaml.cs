using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Cliff.Design.Components
{
    public partial class AddTrackButton : UserControl
    {
        public AddTrackButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
