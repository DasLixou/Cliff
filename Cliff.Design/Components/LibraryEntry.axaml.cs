using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Cliff.Design.Components
{
    public class LibraryEntry : Button
    {
        public static readonly StyledProperty<string> LabelProperty = AvaloniaProperty.Register<TrackController, string>(nameof(Label));

        public string Label
        {
            get { return GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
    }
}
