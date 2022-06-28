using Avalonia.Media;
using Cliff.Design.Commands;
using Cliff.Design.Components;
using Cliff.Design.Utils;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Cliff.Design.ViewModels
{
    internal class TrackControllerListViewModel : BaseViewModel
    {
        public ICommand AddTrackCommand { get; set; } = new AddTrackCommand();

        public ObservableCollection<TrackController> TrackController { get; set; } = new();

        public TrackControllerListViewModel()
        {
            TrackController.Add(new TrackController { Label = "Beeeeeeat", BarColor = 0xffF35A5A.ToBrush(), Icon = ImageUtils.FromAvaRes("avares://Cliff.Design/Assets/drum.png") });
            TrackController.Add(new TrackController { Label = "Leads", BarColor = 0xff3AD95C.ToBrush(), Icon = ImageUtils.FromAvaRes("avares://Cliff.Design/Assets/drum.png") });
        }
    }
}
