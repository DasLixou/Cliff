using Cliff.Design.Commands;
using System.Windows.Input;

namespace Cliff.Design.ViewModels
{
    internal class FootBarViewModel : BaseViewModel
    {
        public ICommand ToggleLibraryCommand { get; set; }

        public FootBarViewModel()
        {
            ToggleLibraryCommand = new AddTrackCommand();
        }
    }
}
