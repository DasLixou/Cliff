using Avalonia.Media;
using Cliff.Design.Commands;
using Cliff.Design.Components;
using System.Windows.Input;

namespace Cliff.Design.ViewModels
{
    internal class TrackEditViewModel : ClosableViewModel
    {
        public ICommand AcceptCommand { get; set; }
        public ICommand DeclineCommand { get; set; }

        public TrackEditViewModel()
        {
            AcceptCommand = new AcceptEditCommand(this);
            DeclineCommand = new DeclineEditCommand(this);
        }

        private TrackController? controller;
        private IBrush barColor;
        private string label;

        public IBrush BarColor
        {
            get { return barColor; }
            set { SetValue(ref barColor, value); }
        }

        public string Label
        {
            get { return label; }
            set { SetValue(ref label, value); }
        }
        public TrackController? Controller
        {
            get { return controller; }
            set { SetValue(ref controller, value); }
        }
    }
}
