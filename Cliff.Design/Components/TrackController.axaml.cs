using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace Cliff.Design.Components
{
    public class TrackController : TemplatedControl
    {
        public static readonly StyledProperty<IBrush> BarColorProperty = AvaloniaProperty.Register<TrackController, IBrush>(nameof(BarColor));
        public static readonly StyledProperty<string> LabelProperty = AvaloniaProperty.Register<TrackController, string>(nameof(Label));
        public static readonly StyledProperty<IImage> IconProperty = AvaloniaProperty.Register<TrackController, IImage>(nameof(Icon));

        public IBrush BarColor
        {
            get { return GetValue(BarColorProperty); }
            set { SetValue(BarColorProperty, value); }
        }

        public string Label
        {
            get { return GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public IImage Icon
        {
            get { return GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

    }
}
