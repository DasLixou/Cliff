using Cliff.Design.Commands;
using System.Windows.Input;

namespace Cliff.Design.ViewModels
{
    internal class TrackControllerListViewModel : BaseViewModel
    {
        public ICommand AddTrackCommand { get; set; } = new AddTrackCommand();
    }
}
