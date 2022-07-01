using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Cliff.Design.ViewModels;
using System.Runtime.CompilerServices;

namespace Cliff.Design.Components
{
    public partial class FootBar : UserControl
    {
        public FootBar()
        {
            InitializeComponent();
            DataContext = new FootBarViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal FootBarViewModel ViewModel() => (FootBarViewModel)DataContext;
    }
}
