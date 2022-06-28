using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Cliff.Design.ViewModels;
using System.Runtime.CompilerServices;

namespace Cliff.Design.Windows
{
    public partial class TrackEditWindow : Window
    {
        public TrackEditWindow()
        {
            InitializeComponent();
            DataContext = new TrackEditViewModel();
            ViewModel().OnRequestClose += () => Close();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal TrackEditViewModel ViewModel() => (TrackEditViewModel)DataContext;
    }
}
