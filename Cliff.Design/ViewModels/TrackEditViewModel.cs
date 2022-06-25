using Avalonia.Media;

namespace Cliff.Design.ViewModels
{
    internal class TrackEditViewModel : BaseViewModel
    {
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
    }
}
