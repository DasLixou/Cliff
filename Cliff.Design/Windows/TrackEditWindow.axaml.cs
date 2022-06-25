using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Cliff.Design.Windows
{
    public partial class TrackEditWindow : Window
    {
        public TrackEditWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
