using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Cliff.Design.ViewModels;
using System.Runtime.CompilerServices;

namespace Cliff.Design.Components
{
    public partial class LibraryWidget : UserControl
    {
        public LibraryWidget()
        {
            InitializeComponent();
            DataContext = new LibraryWidgetViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal LibraryWidgetViewModel ViewModel() => (LibraryWidgetViewModel)DataContext;
    }
}
