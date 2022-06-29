using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Cliff.Design.ViewModels;
using System.Runtime.CompilerServices;

namespace Cliff.Design.Components
{
    public partial class TrackControllerList : UserControl
    {
        public TrackControllerList()
        {
            InitializeComponent();
            DataContext = new TrackControllerListViewModel();
            TrackEditViewModel.AddNewTrack += (controller) => ViewModel().TrackController.Add(controller);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal TrackControllerListViewModel ViewModel() => (TrackControllerListViewModel)DataContext;
    }
}
